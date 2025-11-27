namespace ProyectoFinal.Frontend
{
    partial class FrmRegistroNU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroNU));
            btnAgregar = new Button();
            btnFoto = new Button();
            pictureFoto = new PictureBox();
            cnbTipo = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnCerrarApp = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(779, 560);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(206, 43);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(779, 227);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(203, 40);
            btnFoto.TabIndex = 7;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.BackgroundImageLayout = ImageLayout.Stretch;
            pictureFoto.Location = new Point(703, 273);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(279, 270);
            pictureFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFoto.TabIndex = 33;
            pictureFoto.TabStop = false;
            // 
            // cnbTipo
            // 
            cnbTipo.BackColor = Color.FromArgb(136, 99, 75);
            cnbTipo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(779, 169);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(203, 36);
            cnbTipo.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label8.Location = new Point(703, 235);
            label8.Name = "label8";
            label8.Size = new Size(82, 32);
            label8.TabIndex = 31;
            label8.Text = "Foto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label7.Location = new Point(703, 165);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 30;
            label7.Text = "Tipo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 566);
            label6.Name = "label6";
            label6.Size = new Size(160, 32);
            label6.TabIndex = 29;
            label6.Text = "Contraseña: ";
            label6.Click += label6_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(136, 99, 75);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(178, 566);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(478, 34);
            txtContraseña.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(136, 99, 75);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(137, 490);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(519, 34);
            txtUsuario.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(136, 99, 75);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(137, 410);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(519, 34);
            txtCorreo.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(136, 99, 75);
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtApellidos.ForeColor = Color.White;
            txtApellidos.Location = new Point(137, 252);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(519, 34);
            txtApellidos.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(136, 99, 75);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(137, 329);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(519, 34);
            txtTelefono.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(137, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(519, 34);
            txtNombre.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 410);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 22;
            label5.Text = "Correo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 331);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 21;
            label4.Text = "Teléfono: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 490);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 20;
            label3.Text = "Usuario: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 247);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 19;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 165);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 18;
            label1.Text = "Nombre: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(136, 99, 75);
            panel1.Controls.Add(btnCerrarApp);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 77);
            panel1.TabIndex = 36;
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.Dock = DockStyle.Right;
            btnCerrarApp.FlatStyle = FlatStyle.Popup;
            btnCerrarApp.Image = (Image)resources.GetObject("btnCerrarApp.Image");
            btnCerrarApp.Location = new Point(931, 0);
            btnCerrarApp.Margin = new Padding(2);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(77, 77);
            btnCerrarApp.TabIndex = 37;
            btnCerrarApp.UseVisualStyleBackColor = true;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(259, 9);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(375, 57);
            label9.TabIndex = 7;
            label9.Text = "Crumbul Cookies";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmRegistroNU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1008, 647);
            Controls.Add(panel1);
            Controls.Add(btnAgregar);
            Controls.Add(btnFoto);
            Controls.Add(pictureFoto);
            Controls.Add(cnbTipo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmRegistroNU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistroNU";
            Load += FrmRegistroNU_Load;
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnFoto;
        private PictureBox pictureFoto;
        private ComboBox cnbTipo;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label9;
        private Button btnCerrarApp;
    }
}