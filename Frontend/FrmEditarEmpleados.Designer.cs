namespace ProyectoFinal.Frontend
{
    partial class FrmEditarEmpleados
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
            btnActualizarEmpleado = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            SuspendLayout();
            // 
            // btnActualizarEmpleado
            // 
            btnActualizarEmpleado.BackColor = Color.FromArgb(136, 99, 75);
            btnActualizarEmpleado.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnActualizarEmpleado.ForeColor = Color.White;
            btnActualizarEmpleado.Location = new Point(493, 337);
            btnActualizarEmpleado.Margin = new Padding(4);
            btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            btnActualizarEmpleado.Size = new Size(219, 45);
            btnActualizarEmpleado.TabIndex = 35;
            btnActualizarEmpleado.Text = "Actualizar";
            btnActualizarEmpleado.UseVisualStyleBackColor = false;
            btnActualizarEmpleado.Click += btnActualizarEmpleado_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(536, 131);
            btnFoto.Margin = new Padding(4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(196, 38);
            btnFoto.TabIndex = 34;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.BackgroundImageLayout = ImageLayout.Stretch;
            pictureFoto.Location = new Point(523, 181);
            pictureFoto.Margin = new Padding(4);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(166, 148);
            pictureFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFoto.TabIndex = 33;
            pictureFoto.TabStop = false;
            // 
            // cnbTipo
            // 
            cnbTipo.BackColor = Color.FromArgb(136, 99, 75);
            cnbTipo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            cnbTipo.ForeColor = Color.White;
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(536, 62);
            cnbTipo.Margin = new Padding(4);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(195, 36);
            cnbTipo.TabIndex = 32;
            cnbTipo.SelectedIndexChanged += cnbTipo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(474, 135);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 28);
            label8.TabIndex = 31;
            label8.Text = "Foto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label7.Location = new Point(474, 65);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 28);
            label7.TabIndex = 30;
            label7.Text = "Tipo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label6.Location = new Point(27, 342);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 29;
            label6.Text = "Contraseña: ";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(136, 99, 75);
            txtContraseña.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(180, 342);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(260, 34);
            txtContraseña.TabIndex = 28;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(136, 99, 75);
            txtUsuario.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(146, 284);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(294, 34);
            txtUsuario.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(136, 99, 75);
            txtCorreo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(146, 225);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(294, 34);
            txtCorreo.TabIndex = 26;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(136, 99, 75);
            txtApellidos.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtApellidos.ForeColor = Color.White;
            txtApellidos.Location = new Point(147, 111);
            txtApellidos.Margin = new Padding(4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(293, 34);
            txtApellidos.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(136, 99, 75);
            txtTelefono.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(146, 167);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(294, 34);
            txtTelefono.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(146, 65);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 34);
            txtNombre.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.Location = new Point(27, 229);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 22;
            label5.Text = "Correo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.Location = new Point(27, 175);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 21;
            label4.Text = "Teléfono: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.Location = new Point(27, 288);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 20;
            label3.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(27, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 19;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.Location = new Point(27, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 18;
            label1.Text = "Nombre: ";
            // 
            // FrmEditarEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(754, 440);
            Controls.Add(btnActualizarEmpleado);
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
            Name = "FrmEditarEmpleados";
            Text = "FrmEditarEmpleados";
            Load += FrmEditarEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarProducto;
        private Button btnFoto;
        private PictureBox pbProducto;
        private TextBox txtPrecio;
        private NumericUpDown nudStock;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnActualizarEmpleado;
        private PictureBox pictureFoto;
        private ComboBox cnbTipo;
        private Label label8;
        private Label label7;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
    }
}