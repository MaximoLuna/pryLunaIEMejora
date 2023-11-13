namespace pryLunaIE
{
    partial class frmRegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.mrcPermisos = new System.Windows.Forms.GroupBox();
            this.optRegistroProveedores = new System.Windows.Forms.RadioButton();
            this.mrcFirma = new System.Windows.Forms.GroupBox();
            this.pbxFirma = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mrcPermisos.SuspendLayout();
            this.mrcFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crear Cuenta";
            // 
            // mrcPermisos
            // 
            this.mrcPermisos.Controls.Add(this.optRegistroProveedores);
            this.mrcPermisos.Location = new System.Drawing.Point(235, 62);
            this.mrcPermisos.Name = "mrcPermisos";
            this.mrcPermisos.Size = new System.Drawing.Size(206, 54);
            this.mrcPermisos.TabIndex = 28;
            this.mrcPermisos.TabStop = false;
            this.mrcPermisos.Text = "Permisos";
            // 
            // optRegistroProveedores
            // 
            this.optRegistroProveedores.AutoSize = true;
            this.optRegistroProveedores.Location = new System.Drawing.Point(6, 19);
            this.optRegistroProveedores.Name = "optRegistroProveedores";
            this.optRegistroProveedores.Size = new System.Drawing.Size(142, 17);
            this.optRegistroProveedores.TabIndex = 20;
            this.optRegistroProveedores.TabStop = true;
            this.optRegistroProveedores.Text = "Registro de Proveedores";
            this.optRegistroProveedores.UseVisualStyleBackColor = true;
            // 
            // mrcFirma
            // 
            this.mrcFirma.Controls.Add(this.pbxFirma);
            this.mrcFirma.Controls.Add(this.btnBorrar);
            this.mrcFirma.Location = new System.Drawing.Point(115, 149);
            this.mrcFirma.Name = "mrcFirma";
            this.mrcFirma.Size = new System.Drawing.Size(206, 204);
            this.mrcFirma.TabIndex = 27;
            this.mrcFirma.TabStop = false;
            this.mrcFirma.Text = "Firma";
            // 
            // pbxFirma
            // 
            this.pbxFirma.BackColor = System.Drawing.Color.White;
            this.pbxFirma.Location = new System.Drawing.Point(8, 12);
            this.pbxFirma.Name = "pbxFirma";
            this.pbxFirma.Size = new System.Drawing.Size(192, 152);
            this.pbxFirma.TabIndex = 8;
            this.pbxFirma.TabStop = false;
            this.pbxFirma.Click += new System.EventHandler(this.pbxFirma_Click);
            this.pbxFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxFirma_MouseDown);
            this.pbxFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxFirma_MouseMove);
            this.pbxFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxFirma_MouseUp);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(64, 170);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(77, 104);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '+';
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 26;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 13);
            this.label.TabIndex = 25;
            this.label.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(179, 368);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Usuario ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(77, 62);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 402);
            this.Controls.Add(this.mrcPermisos);
            this.Controls.Add(this.mrcFirma);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Name = "frmRegistroUsuario";
            this.Text = "Registrar Usuario";
            this.mrcPermisos.ResumeLayout(false);
            this.mrcPermisos.PerformLayout();
            this.mrcFirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox mrcPermisos;
        private System.Windows.Forms.RadioButton optRegistroProveedores;
        private System.Windows.Forms.GroupBox mrcFirma;
        private System.Windows.Forms.PictureBox pbxFirma;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}