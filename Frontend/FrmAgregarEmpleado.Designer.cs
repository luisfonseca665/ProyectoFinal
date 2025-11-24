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
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 203);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Usuario: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 102);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Teléfono: ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 146);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Correo: ";
            label5.Click += label5_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 27);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(87, 99);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 27);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(87, 54);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(254, 27);
            txtApellidos.TabIndex = 7;
            txtApellidos.TextChanged += txtApellidos_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(87, 146);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 8;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(87, 196);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(254, 27);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(106, 255);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(234, 27);
            txtContraseña.TabIndex = 10;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 255);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "Contraseña: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 19);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 12;
            label7.Text = "Tipo: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 76);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 13;
            label8.Text = "Foto: ";
            // 
            // cnbTipo
            // 
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(436, 18);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(157, 28);
            cnbTipo.TabIndex = 14;
            cnbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(377, 106);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(216, 117);
            pictureFoto.TabIndex = 15;
            pictureFoto.TabStop = false;
            pictureFoto.Click += pictureFoto_Click;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(436, 71);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(157, 29);
            btnFoto.TabIndex = 16;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(417, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(175, 29);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 131, 133);
            ClientSize = new Size(615, 330);
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