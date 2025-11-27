namespace ProyectoFinal.Frontend
{
    partial class FrmAgregarProducto
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
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nudStock = new NumericUpDown();
            txtPrecio = new TextBox();
            pbProducto = new PictureBox();
            btnFoto = new Button();
            btnAgregarProducto = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.Location = new Point(11, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 145);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.Location = new Point(621, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 562);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 233);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 4;
            label5.Text = "Descripcion:";
            label5.Click += label5_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(136, 99, 75);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(119, 65);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(431, 39);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(132, 145);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(418, 39);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(136, 99, 75);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(11, 294);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(539, 232);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(136, 99, 75);
            nudStock.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(712, 65);
            nudStock.Margin = new Padding(2);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(219, 39);
            nudStock.TabIndex = 4;
            nudStock.ValueChanged += nudStock_ValueChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(136, 99, 75);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(110, 562);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(440, 39);
            txtPrecio.TabIndex = 3;
            // 
            // pbProducto
            // 
            pbProducto.Location = new Point(621, 202);
            pbProducto.Margin = new Padding(2);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(310, 309);
            pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProducto.TabIndex = 11;
            pbProducto.TabStop = false;
            pbProducto.Click += pbProducto_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(700, 134);
            btnFoto.Margin = new Padding(2);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(231, 50);
            btnFoto.TabIndex = 5;
            btnFoto.Text = "Seleccionar foto.";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregarProducto.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(621, 562);
            btnAgregarProducto.Margin = new Padding(2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(310, 39);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto.";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label7.Location = new Point(621, 138);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 32);
            label7.TabIndex = 14;
            label7.Text = "Foto:";
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(958, 647);
            Controls.Add(label7);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnFoto);
            Controls.Add(pbProducto);
            Controls.Add(txtPrecio);
            Controls.Add(nudStock);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmAgregarProducto";
            Text = "FrmActualizarProducto";
            Load += FrmAgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nudStock;
        private TextBox txtPrecio;
        private PictureBox pbProducto;
        private Button btnFoto;
        private Button btnAgregarProducto;
        private Label label7;
    }
}