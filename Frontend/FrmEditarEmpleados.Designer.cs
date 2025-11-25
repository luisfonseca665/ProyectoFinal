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
            btnActualizarEmpleado.Location = new Point(387, 240);
            btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            btnActualizarEmpleado.Size = new Size(175, 36);
            btnActualizarEmpleado.TabIndex = 35;
            btnActualizarEmpleado.Text = "Agregar Empleado";
            btnActualizarEmpleado.UseVisualStyleBackColor = false;
            btnActualizarEmpleado.Click += btnActualizarEmpleado_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(417, 78);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(157, 30);
            btnFoto.TabIndex = 34;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(367, 118);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(207, 109);
            pictureFoto.TabIndex = 33;
            pictureFoto.TabStop = false;
            // 
            // cnbTipo
            // 
            cnbTipo.BackColor = Color.FromArgb(136, 99, 75);
            cnbTipo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            cnbTipo.ForeColor = Color.White;
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(417, 23);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(157, 31);
            cnbTipo.TabIndex = 32;
            cnbTipo.SelectedIndexChanged += cnbTipo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(367, 82);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 31;
            label8.Text = "Foto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label7.Location = new Point(367, 26);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 30;
            label7.Text = "Tipo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label6.Location = new Point(10, 247);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 29;
            label6.Text = "Contraseña: ";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(136, 99, 75);
            txtContraseña.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtContraseña.Location = new Point(132, 247);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(209, 30);
            txtContraseña.TabIndex = 28;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(136, 99, 75);
            txtUsuario.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtUsuario.Location = new Point(105, 201);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(236, 30);
            txtUsuario.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(136, 99, 75);
            txtCorreo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtCorreo.Location = new Point(105, 154);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 30);
            txtCorreo.TabIndex = 26;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(136, 99, 75);
            txtApellidos.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtApellidos.Location = new Point(106, 62);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(235, 30);
            txtApellidos.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(136, 99, 75);
            txtTelefono.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtTelefono.Location = new Point(105, 107);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 30);
            txtTelefono.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtNombre.Location = new Point(105, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 30);
            txtNombre.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.Location = new Point(10, 157);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 22;
            label5.Text = "Correo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.Location = new Point(10, 114);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 21;
            label4.Text = "Teléfono: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.Location = new Point(10, 204);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 20;
            label3.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(10, 69);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 19;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.Location = new Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 18;
            label1.Text = "Nombre: ";
            // 
            // FrmEditarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(603, 353);
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