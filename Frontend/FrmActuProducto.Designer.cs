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
            btnActualizarProducto.Location = new Point(500, 377);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(256, 34);
            btnActualizarProducto.TabIndex = 27;
            btnActualizarProducto.Text = "Actualizar Producto.";
            btnActualizarProducto.UseVisualStyleBackColor = true;
            btnActualizarProducto.Click += btnActualizarProducto_Click;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(559, 106);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(197, 34);
            btnFoto.TabIndex = 26;
            btnFoto.Text = "Actualizar foto.";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pbProducto
            // 
            pbProducto.Location = new Point(500, 146);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(256, 200);
            pbProducto.TabIndex = 25;
            pbProducto.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(115, 377);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(316, 31);
            txtPrecio.TabIndex = 24;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(576, 40);
            nudStock.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 31);
            nudStock.TabIndex = 23;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(45, 219);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(386, 112);
            txtDescripcion.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(133, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 31);
            txtNombre.TabIndex = 21;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(126, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(305, 31);
            txtCodigo.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(500, 106);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 19;
            label6.Text = "Foto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 171);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 18;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 377);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 17;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 42);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 16;
            label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 100);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 14;
            label1.Text = "Codigo:";
            // 
            // FrmActuProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
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