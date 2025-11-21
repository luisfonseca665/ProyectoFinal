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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnTienda = new Button();
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
            pnlMenu.Controls.Add(button5);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Controls.Add(btnTienda);
            pnlMenu.Controls.Add(pnlUsuario);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(277, 659);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(0, 600);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(277, 59);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.icons8_report_50;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 445);
            button5.Name = "button5";
            button5.Size = new Size(277, 59);
            button5.TabIndex = 6;
            button5.Text = "Reportes";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.icons8_users_50;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 386);
            button4.Name = "button4";
            button4.Size = new Size(277, 59);
            button4.TabIndex = 5;
            button4.Text = "Usuarios";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 327);
            button3.Name = "button3";
            button3.Size = new Size(277, 59);
            button3.TabIndex = 4;
            button3.Text = "Auditorias";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_employees_48;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 268);
            button2.Name = "button2";
            button2.Size = new Size(277, 59);
            button2.TabIndex = 3;
            button2.Text = "Empleados";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_products_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 209);
            button1.Name = "button1";
            button1.Size = new Size(277, 59);
            button1.TabIndex = 2;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnTienda
            // 
            btnTienda.Dock = DockStyle.Top;
            btnTienda.FlatStyle = FlatStyle.Flat;
            btnTienda.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTienda.ForeColor = Color.White;
            btnTienda.Image = Properties.Resources.icons8_buy_50;
            btnTienda.ImageAlign = ContentAlignment.MiddleLeft;
            btnTienda.Location = new Point(0, 150);
            btnTienda.Name = "btnTienda";
            btnTienda.Size = new Size(277, 59);
            btnTienda.TabIndex = 0;
            btnTienda.Text = "Comprar";
            btnTienda.UseVisualStyleBackColor = true;
            btnTienda.Click += btnTienda_Click;
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(lblusuario);
            pnlUsuario.Controls.Add(pcbUsuario);
            pnlUsuario.Dock = DockStyle.Top;
            pnlUsuario.Location = new Point(0, 0);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(277, 150);
            pnlUsuario.TabIndex = 0;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(156, 72);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(94, 25);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "USUARIO";
            lblusuario.Click += lblusuario_Click;
            // 
            // pcbUsuario
            // 
            pcbUsuario.Dock = DockStyle.Left;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(0, 0);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(150, 150);
            pcbUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUsuario.TabIndex = 0;
            pcbUsuario.TabStop = false;
            // 
            // pnlApp
            // 
            pnlApp.BackColor = Color.Wheat;
            pnlApp.Dock = DockStyle.Fill;
            pnlApp.Location = new Point(277, 0);
            pnlApp.Name = "pnlApp";
            pnlApp.Size = new Size(782, 659);
            pnlApp.TabIndex = 1;
            pnlApp.Paint += pnlApp_Paint;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 659);
            Controls.Add(pnlApp);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnTienda;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnSalir;
        private Label lblusuario;
    }
}