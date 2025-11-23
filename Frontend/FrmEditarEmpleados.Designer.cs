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
            btnActualizarEmpleado.BackColor = Color.White;
            btnActualizarEmpleado.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnActualizarEmpleado.ForeColor = Color.Black;
            btnActualizarEmpleado.Location = new Point(515, 325);
            btnActualizarEmpleado.Margin = new Padding(4);
            btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            btnActualizarEmpleado.Size = new Size(219, 36);
            btnActualizarEmpleado.TabIndex = 35;
            btnActualizarEmpleado.Text = "Agregar Empleado";
            btnActualizarEmpleado.UseVisualStyleBackColor = false;
            btnActualizarEmpleado.Click += btnActualizarEmpleado_Click;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(538, 99);
            btnFoto.Margin = new Padding(4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(196, 36);
            btnFoto.TabIndex = 34;
            btnFoto.Text = "Seleccionar foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(464, 153);
            pictureFoto.Margin = new Padding(4);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(270, 136);
            pictureFoto.TabIndex = 33;
            pictureFoto.TabStop = false;
            // 
            // cnbTipo
            // 
            cnbTipo.FormattingEnabled = true;
            cnbTipo.Location = new Point(539, 29);
            cnbTipo.Margin = new Padding(4);
            cnbTipo.Name = "cnbTipo";
            cnbTipo.Size = new Size(195, 33);
            cnbTipo.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(455, 105);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 31;
            label8.Text = "Foto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 34);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 30;
            label7.Text = "Tipo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 329);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 29;
            label6.Text = "Contraseña: ";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(133, 329);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(292, 31);
            txtContraseña.TabIndex = 28;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(109, 255);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(316, 31);
            txtUsuario.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(109, 193);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(316, 31);
            txtCorreo.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(109, 78);
            txtApellidos.Margin = new Padding(4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(316, 31);
            txtApellidos.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(109, 134);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(316, 31);
            txtTelefono.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 28);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 31);
            txtNombre.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 193);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 22;
            label5.Text = "Correo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 21;
            label4.Text = "Teléfono: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 264);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 20;
            label3.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 19;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 18;
            label1.Text = "Nombre: ";
            // 
            // FrmEditarEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 131, 133);
            ClientSize = new Size(754, 441);
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