namespace ProyectoFinal.Frontend
{
    partial class FrmAgregarEmpleado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cnbTipo = new ComboBox();
            pictureFoto = new PictureBox();
            btnFoto = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.Location = new Point(25, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(22, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.Location = new Point(25, 284);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Usuario: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.Location = new Point(25, 175);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 3;
            label4.Text = "Teléfono: ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.Location = new Point(25, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 4;
            label5.Text = "Correo: ";
            label5.Click += label5_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(133, 63);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 34);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(136, 99, 75);
            txtTelefono.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(133, 172);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(316, 34);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(136, 99, 75);
            txtApellidos.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtApellidos.ForeColor = Color.White;
            txtApellidos.Location = new Point(133, 111);
            txtApellidos.Margin = new Padding(4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(316, 34);
            txtApellidos.TabIndex = 7;
            txtApellidos.TextChanged += txtApellidos_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(136, 99, 75);
            txtCorreo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(133, 228);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(316, 34);
            txtCorreo.TabIndex = 8;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(136, 99, 75);
            txtUsuario.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(133, 284);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(316, 34);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(136, 99, 75);
            txtContraseña.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(174, 338);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(275, 34);
            txtContraseña.TabIndex = 10;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label6.Location = new Point(22, 338);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 11;
            label6.Text = "Contraseña: ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label7.Location = new Point(474, 67);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 28);
            label7.TabIndex = 12;
            label7.Text = "Tipo: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label8.Location = new Point(474, 138);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 28);
            label8.TabIndex = 13;
            label8.Text = "Foto: ";
            // 
            // cnbTipo
            // 
            cnbTipo.BackColor = Color.FromArgb(136, 99, 75);
            cnbTipo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            cnbTipo.ForeColor = Color.White;
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(558, 65);
            cnbTipo.Margin = new Padding(4);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(195, 36);
            cnbTipo.TabIndex = 14;
            cnbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(484, 175);
            pictureFoto.Margin = new Padding(4);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(270, 146);
            pictureFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFoto.TabIndex = 15;
            pictureFoto.TabStop = false;
            pictureFoto.Click += pictureFoto_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(558, 132);
            btnFoto.Margin = new Padding(4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(196, 36);
            btnFoto.TabIndex = 16;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(507, 338);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(219, 46);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(769, 441);
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
            Margin = new Padding(4);
            Name = "FrmAgregarEmpleado";
            Text = "FrmAgregarEmpleado";
            Load += FrmAgregarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cnbTipo;
        private PictureBox pictureFoto;
        private Button btnFoto;
        private Button btnAgregar;
    }
}