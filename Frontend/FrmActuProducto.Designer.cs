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
            btnActualizarProducto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnActualizarProducto.ForeColor = Color.White;
            btnActualizarProducto.Location = new Point(400, 302);
            btnActualizarProducto.Margin = new Padding(2);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(205, 37);
            btnActualizarProducto.TabIndex = 27;
            btnActualizarProducto.Text = "Actualizar Producto.";
            btnActualizarProducto.UseVisualStyleBackColor = false;
            btnActualizarProducto.Click += btnActualizarProducto_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(446, 80);
            btnFoto.Margin = new Padding(2);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(158, 33);
            btnFoto.TabIndex = 26;
            btnFoto.Text = "Actualizar foto.";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pbProducto
            // 
            pbProducto.Location = new Point(400, 117);
            pbProducto.Margin = new Padding(2);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(205, 160);
            pbProducto.TabIndex = 25;
            pbProducto.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(136, 99, 75);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(101, 298);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(244, 30);
            txtPrecio.TabIndex = 24;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(136, 99, 75);
            nudStock.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(461, 32);
            nudStock.Margin = new Padding(2);
            nudStock.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(144, 30);
            nudStock.TabIndex = 23;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(136, 99, 75);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(19, 171);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(326, 90);
            txtDescripcion.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(101, 80);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 30);
            txtNombre.TabIndex = 21;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(136, 99, 75);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(101, 31);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(244, 30);
            txtCodigo.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label6.Location = new Point(388, 81);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 19;
            label6.Text = "Foto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.Location = new Point(19, 146);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 18;
            label5.Text = "Descripcion:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label4.Location = new Point(19, 302);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 17;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label3.Location = new Point(388, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 16;
            label3.Text = "Stock:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(19, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label1.Location = new Point(19, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 14;
            label1.Text = "Código:";
            label1.Click += label1_Click;
            // 
            // FrmActuProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(642, 360);
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