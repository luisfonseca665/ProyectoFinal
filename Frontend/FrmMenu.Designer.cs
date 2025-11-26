namespace ProyectoFinal.Frontend
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            pnlMenu = new Panel();
            btnSalir = new Button();
            btnReportes = new Button();
            btnAuditorias = new Button();
            btnEmpleados = new Button();
            btnProductos = new Button();
            btnComprar = new Button();
            pnlUsuario = new Panel();
            lblusuario = new Label();
            pcbUsuario = new PictureBox();
            pnlApp = new Panel();
            pnlMenu.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(136, 99, 75);
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnAuditorias);
            pnlMenu.Controls.Add(btnEmpleados);
            pnlMenu.Controls.Add(btnProductos);
            pnlMenu.Controls.Add(btnComprar);
            pnlMenu.Controls.Add(pnlUsuario);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(278, 808);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(0, 749);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(278, 59);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = Properties.Resources.icons8_report_50;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 386);
            btnReportes.Margin = new Padding(2);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(278, 59);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnAuditorias
            // 
            btnAuditorias.Dock = DockStyle.Top;
            btnAuditorias.FlatStyle = FlatStyle.Flat;
            btnAuditorias.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditorias.ForeColor = Color.White;
            btnAuditorias.Image = (Image)resources.GetObject("btnAuditorias.Image");
            btnAuditorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditorias.Location = new Point(0, 327);
            btnAuditorias.Margin = new Padding(2);
            btnAuditorias.Name = "btnAuditorias";
            btnAuditorias.Size = new Size(278, 59);
            btnAuditorias.TabIndex = 4;
            btnAuditorias.Text = "Auditorias";
            btnAuditorias.UseVisualStyleBackColor = true;
            btnAuditorias.Click += btnAuditorias_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = Properties.Resources.icons8_employees_48;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(0, 268);
            btnEmpleados.Margin = new Padding(2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(278, 59);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += button2_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.icons8_products_48;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 209);
            btnProductos.Margin = new Padding(2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(278, 59);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnComprar
            // 
            btnComprar.Dock = DockStyle.Top;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.ForeColor = Color.White;
            btnComprar.Image = Properties.Resources.icons8_buy_50;
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(0, 150);
            btnComprar.Margin = new Padding(2);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(278, 59);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnTienda_Click;
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(lblusuario);
            pnlUsuario.Controls.Add(pcbUsuario);
            pnlUsuario.Dock = DockStyle.Top;
            pnlUsuario.Location = new Point(0, 0);
            pnlUsuario.Margin = new Padding(2);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(278, 150);
            pnlUsuario.TabIndex = 0;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(156, 72);
            lblusuario.Margin = new Padding(2, 0, 2, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(94, 25);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "USUARIO";
            lblusuario.Click += lblusuario_Click;
            // 
            // pcbUsuario
            // 
            pcbUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            pcbUsuario.Dock = DockStyle.Left;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(0, 0);
            pcbUsuario.Margin = new Padding(2);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(150, 150);
            pcbUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUsuario.TabIndex = 0;
            pcbUsuario.TabStop = false;
            pcbUsuario.Click += pcbUsuario_Click;
            // 
            // pnlApp
            // 
            pnlApp.BackColor = Color.FromArgb(255, 224, 192);
            pnlApp.Dock = DockStyle.Fill;
            pnlApp.Location = new Point(278, 0);
            pnlApp.Margin = new Padding(2);
            pnlApp.Name = "pnlApp";
            pnlApp.Size = new Size(981, 808);
            pnlApp.TabIndex = 1;
            pnlApp.Paint += pnlApp_Paint;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 808);
            Controls.Add(pnlApp);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            pnlMenu.ResumeLayout(false);
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlUsuario;
        private PictureBox pcbUsuario;
        private Panel pnlApp;
        private Button btnComprar;
        private Button btnReportes;
        private Button btnAuditorias;
        private Button btnEmpleados;
        private Button btnProductos;
        private Button btnSalir;
        private Label lblusuario;
    }
}