namespace ProyectoFinal.Frontend
{
    partial class FrmActuProducto
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
            btnActualizarProducto = new Button();
            btnFoto = new Button();
            pbProducto = new PictureBox();
            txtPrecio = new TextBox();
            nudStock = new NumericUpDown();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.BackColor = Color.FromArgb(136, 99, 75);
            btnActualizarProducto.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnActualizarProducto.ForeColor = Color.White;
            btnActualizarProducto.Location = new Point(609, 559);
            btnActualizarProducto.Margin = new Padding(2);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(300, 43);
            btnActualizarProducto.TabIndex = 6;
            btnActualizarProducto.Text = "Actualizar Producto.";
            btnActualizarProducto.UseVisualStyleBackColor = false;
            btnActualizarProducto.Click += btnActualizarProducto_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(695, 151);
            btnFoto.Margin = new Padding(2);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(214, 42);
            btnFoto.TabIndex = 5;
            btnFoto.Text = "Actualizar foto.";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pbProducto
            // 
            pbProducto.BackgroundImageLayout = ImageLayout.Stretch;
            pbProducto.Location = new Point(609, 221);
            pbProducto.Margin = new Padding(2);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(300, 304);
            pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProducto.TabIndex = 25;
            pbProducto.TabStop = false;
            pbProducto.Click += pbProducto_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(136, 99, 75);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(114, 568);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(452, 34);
            txtPrecio.TabIndex = 3;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(136, 99, 75);
            nudStock.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(717, 64);
            nudStock.Margin = new Padding(2);
            nudStock.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(192, 39);
            nudStock.TabIndex = 4;
            nudStock.ValueChanged += nudStock_ValueChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(136, 99, 75);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(11, 293);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(555, 232);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(132, 159);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(434, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(136, 99, 75);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(110, 64);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(456, 34);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label6.Location = new Point(609, 161);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 32);
            label6.TabIndex = 19;
            label6.Text = "Foto:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 241);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 18;
            label5.Text = "Descripcion:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 584);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 17;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.Location = new Point(609, 66);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 16;
            label3.Text = "Stock:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 161);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.Location = new Point(11, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 14;
            label1.Text = "Código:";
            label1.Click += label1_Click;
            // 
            // FrmActuProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(958, 647);
            Controls.Add(btnActualizarProducto);
            Controls.Add(btnFoto);
            Controls.Add(pbProducto);
            Controls.Add(txtPrecio);
            Controls.Add(nudStock);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmActuProducto";
            Text = "FrmActuProducto";
            Load += FrmActuProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizarProducto;
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
    }
}