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
            btnActualizarEmpleado.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnActualizarEmpleado.ForeColor = Color.White;
            btnActualizarEmpleado.Location = new Point(706, 501);
            btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            btnActualizarEmpleado.Size = new Size(245, 38);
            btnActualizarEmpleado.TabIndex = 8;
            btnActualizarEmpleado.Text = "Actualizar";
            btnActualizarEmpleado.UseVisualStyleBackColor = false;
            btnActualizarEmpleado.Click += btnActualizarEmpleado_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(706, 138);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(245, 39);
            btnFoto.TabIndex = 7;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.BackgroundImageLayout = ImageLayout.Stretch;
            pictureFoto.Location = new Point(619, 183);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(332, 274);
            pictureFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFoto.TabIndex = 33;
            pictureFoto.TabStop = false;
            // 
            // cnbTipo
            // 
            cnbTipo.BackColor = Color.FromArgb(136, 99, 75);
            cnbTipo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            cnbTipo.ForeColor = Color.White;
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(706, 56);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(245, 36);
            cnbTipo.TabIndex = 6;
            cnbTipo.SelectedIndexChanged += cnbTipo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(619, 147);
            label8.Name = "label8";
            label8.Size = new Size(82, 32);
            label8.TabIndex = 31;
            label8.Text = "Foto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label7.Location = new Point(619, 58);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 30;
            label7.Text = "Tipo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label6.Location = new Point(12, 505);
            label6.Name = "label6";
            label6.Size = new Size(160, 32);
            label6.TabIndex = 29;
            label6.Text = "Contraseña: ";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(136, 99, 75);
            txtContraseña.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(178, 505);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(400, 34);
            txtContraseña.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(136, 99, 75);
            txtUsuario.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(142, 424);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(436, 34);
            txtUsuario.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(136, 99, 75);
            txtCorreo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(142, 338);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(436, 34);
            txtCorreo.TabIndex = 3;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(136, 99, 75);
            txtApellidos.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtApellidos.ForeColor = Color.White;
            txtApellidos.Location = new Point(142, 145);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(436, 34);
            txtApellidos.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(136, 99, 75);
            txtTelefono.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(142, 239);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(436, 34);
            txtTelefono.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(142, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(436, 34);
            txtNombre.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label5.Location = new Point(12, 340);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 22;
            label5.Text = "Correo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 21;
            label4.Text = "Teléfono: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label3.Location = new Point(12, 425);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 20;
            label3.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 19;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 18;
            label1.Text = "Nombre: ";
            // 
            // FrmEditarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(990, 600);
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