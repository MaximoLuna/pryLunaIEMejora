using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Drawing;

namespace pryLunaIE
{
    internal class ClsUser
    {
        //Guardamos datos del usuario actual
         public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Rol { get; set; }

        string connectionString;
        public void ConectarBase()
        {
            string rutaArchivo = @"../../archivos/usuarios.accdb";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            OleDbConnection conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Test");
            }
            finally
            {
                conn.Close();
            }
        }


        //procedimiento validar usuario y contraseña
        public static ClsUser Login(string usuario, string contraseña)
        {
            string rutaArchivo = @"../../archivos/usuarios.accdb";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT IdUsuario, Usuario, Contraseña, Rol FROM Usuarios WHERE Usuario = ? AND Contraseña = ?";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@p1", usuario);
                        cmd.Parameters.AddWithValue("@p2", contraseña);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ClsUser currentUser = new ClsUser
                                {
                                    Id = reader.GetInt32(0),
                                    User = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    Rol = reader.GetString(3)
                                };
                                return currentUser;
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }
            return null;
        }

        public void RegistrarUsuario(string user, string password, string rol)
        {
            string rutaArchivo = @"../../archivos/usuarios.accdb";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                string sqlCheckUser = "SELECT Usuario FROM Usuarios WHERE Usuario = ?";
                using (OleDbCommand cmdCheckUser = new OleDbCommand(sqlCheckUser, conn))
                {
                    cmdCheckUser.Parameters.AddWithValue("param1", user);
                    using (OleDbDataReader reader = cmdCheckUser.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Usuario Existente");
                            return; 
                        }
                    }
                }

                string sqlInsertUser = "INSERT INTO Usuarios(Usuario, Contraseña, Rol) VALUES (?, ?, ?)";
                using (OleDbCommand cmdInsertUser = new OleDbCommand(sqlInsertUser, conn))
                {
                    cmdInsertUser.Parameters.AddWithValue("param1", user);
                    cmdInsertUser.Parameters.AddWithValue("param2", password);
                    cmdInsertUser.Parameters.AddWithValue("param3", rol);

                    cmdInsertUser.ExecuteNonQuery();
                }
            }
        }


        public static void RegisterLog(string usuario)
        {
            StreamWriter sw = new StreamWriter("logInicio.txt", true);
            sw.WriteLine("Inicio sesion el usuario: " + usuario + " - Fecha: " + DateTime.Now);
            sw.Close();
        }

        public void MenuLog(int idUsuario, DateTime fecha, string categoria)
        {
            string rutaArchivo = @"../../archivos/usuarios.accdb";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            // Usar parámetros en lugar de insertar valores directamente en la sentencia SQL
            string sql = "INSERT INTO Logs(IdUsuario, Fecha, Categoria) VALUES (?, ?, ?)";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("param1", idUsuario);
                        cmd.Parameters.AddWithValue("param2", fecha);
                        cmd.Parameters.AddWithValue("param3", categoria);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void IngresarUsuario(string usuario, string contrasenia, bool permisoProv, Image firma)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Convertir la firma en byteswqeqwe
                    byte[] firmaBytes;
                    using (MemoryStream m = new MemoryStream())
                    {
                        firma.Save(m, System.Drawing.Imaging.ImageFormat.Png); //seleccionamos el formato 
                        firmaBytes = m.ToArray();
                    }

                    // Insertar los datos en la base de datos
                    string Query = "INSERT INTO Usuarios (Nombre, Contrasenia, PermisoProv, Firma) VALUES (@Nombre, @Contrasenia, @PermisoProv, @Firma)";

                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", usuario);
                        cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                        cmd.Parameters.AddWithValue("@PermisoProv", permisoProv);
                        cmd.Parameters.AddWithValue("@Firma", firmaBytes);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
