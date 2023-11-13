namespace pryLunaIE
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuActivo = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.activosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusUserMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUserTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuActivo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuActivo
            // 
            this.menuActivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1});
            this.menuActivo.Location = new System.Drawing.Point(0, 0);
            this.menuActivo.Name = "menuActivo";
            this.menuActivo.Size = new System.Drawing.Size(800, 24);
            this.menuActivo.TabIndex = 0;
            this.menuActivo.Text = "menuStrip1";
            this.menuActivo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuActivo_ItemClicked);
            // 
            // gestiónToolStripMenuItem1
            // 
            this.gestiónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem1});
            this.gestiónToolStripMenuItem1.Name = "gestiónToolStripMenuItem1";
            this.gestiónToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem1.Text = "Gestión";
            // 
            // proveedorToolStripMenuItem1
            // 
            this.proveedorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedoresToolStripMenuItem});
            this.proveedorToolStripMenuItem1.Name = "proveedorToolStripMenuItem1";
            this.proveedorToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.proveedorToolStripMenuItem1.Text = "Proveedor";
            // 
            // registroDeProveedoresToolStripMenuItem
            // 
            this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
            this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registroDeProveedoresToolStripMenuItem.Text = "Registro de proveedores";
            this.registroDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeProveedoresToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem2});
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
            this.proveedoresToolStripMenuItem1.Text = "Listado/Reportes";
            // 
            // proveedoresToolStripMenuItem2
            // 
            this.proveedoresToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem1});
            this.proveedoresToolStripMenuItem2.Name = "proveedoresToolStripMenuItem2";
            this.proveedoresToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem2.Text = "Proveedores";
            // 
            // activosToolStripMenuItem1
            // 
            this.activosToolStripMenuItem1.Name = "activosToolStripMenuItem1";
            this.activosToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.activosToolStripMenuItem1.Text = "Activos";
            this.activosToolStripMenuItem1.Click += new System.EventHandler(this.activosToolStripMenuItem1_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // registroProveedoresToolStripMenuItem
            // 
            this.registroProveedoresToolStripMenuItem.Name = "registroProveedoresToolStripMenuItem";
            this.registroProveedoresToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registroProveedoresToolStripMenuItem.Text = "Registro proveedores";
            this.registroProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registroProveedoresToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.listadoToolStripMenuItem.Text = "Listado/Reportes";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activosToolStripMenuItem.Text = "Activos";
            this.activosToolStripMenuItem.Click += new System.EventHandler(this.activosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUserMain,
            this.statusUserTitle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUserMain
            // 
            this.statusUserMain.Name = "statusUserMain";
            this.statusUserMain.Size = new System.Drawing.Size(47, 17);
            this.statusUserMain.Text = "Usuario";
            // 
            // statusUserTitle
            // 
            this.statusUserTitle.Name = "statusUserTitle";
            this.statusUserTitle.Size = new System.Drawing.Size(47, 17);
            this.statusUserTitle.Text = "Usuario";
            // 
            // lblUserMain
            // 
            this.lblUserMain.Name = "lblUserMain";
            this.lblUserMain.Size = new System.Drawing.Size(30, 17);
            this.lblUserMain.Text = "User";
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(33, 17);
            this.lblUserTitle.Text = ":User";
            this.lblUserTitle.Click += new System.EventHandler(this.lblUserTitle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateMenu
            // 
            this.lblDateMenu.Name = "lblDateMenu";
            this.lblDateMenu.Size = new System.Drawing.Size(118, 17);
            this.lblDateMenu.Text = "toolStripStatusLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuActivo);
            this.MainMenuStrip = this.menuActivo;
            this.Name = "frmMain";
            this.Text = "Sistema de gestión de ventas de seguro";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuActivo.ResumeLayout(false);
            this.menuActivo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuActivo;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserMain;
        private System.Windows.Forms.ToolStripStatusLabel lblUserTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblDateMenu;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel statusUserMain;
        private System.Windows.Forms.ToolStripStatusLabel statusUserTitle;
    }
}

