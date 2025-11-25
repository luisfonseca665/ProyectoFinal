namespace ProyectoFinal.Frontend
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btniniciarsesion = new Button();
            lblRegistro = new Label();
            panel1 = new Panel();
            btnCerrarApp = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.Location = new Point(28, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(136, 99, 79);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(127, 109);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(236, 34);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(28, 172);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(136, 99, 79);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(157, 172);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(206, 34);
            txtPassword.TabIndex = 3;
            // 
            // btniniciarsesion
            // 
            btniniciarsesion.BackColor = Color.FromArgb(136, 99, 79);
            btniniciarsesion.FlatStyle = FlatStyle.Flat;
            btniniciarsesion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btniniciarsesion.ForeColor = Color.White;
            btniniciarsesion.Location = new Point(188, 244);
            btniniciarsesion.Margin = new Padding(2, 2, 2, 2);
            btniniciarsesion.Name = "btniniciarsesion";
            btniniciarsesion.Size = new Size(128, 38);
            btniniciarsesion.TabIndex = 4;
            btniniciarsesion.Text = "Iniciar Sesion.";
            btniniciarsesion.UseVisualStyleBackColor = false;
            btniniciarsesion.Click += btniniciarsesion_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblRegistro.Location = new Point(157, 294);
            lblRegistro.Margin = new Padding(2, 0, 2, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(192, 20);
            lblRegistro.TabIndex = 5;
            lblRegistro.Text = "¿No tienes cuenta? Da clic";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(136, 99, 75);
            panel1.Controls.Add(btnCerrarApp);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 77);
            panel1.TabIndex = 6;
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.Dock = DockStyle.Right;
            btnCerrarApp.FlatStyle = FlatStyle.Popup;
            btnCerrarApp.Image = (Image)resources.GetObject("btnCerrarApp.Image");
            btnCerrarApp.Location = new Point(476, 0);
            btnCerrarApp.Margin = new Padding(2, 2, 2, 2);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(77, 77);
            btnCerrarApp.TabIndex = 8;
            btnCerrarApp.UseVisualStyleBackColor = true;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(110, 11);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 41);
            label3.TabIndex = 7;
            label3.Text = "Crumbul Cookies";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(367, 94);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(553, 323);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblRegistro);
            Controls.Add(btniniciarsesion);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtPassword;
        private Button btniniciarsesion;
        private Label lblRegistro;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnCerrarApp;
    }
}