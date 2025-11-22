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
            label6 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nudStock = new NumericUpDown();
            txtPrecio = new TextBox();
            pbProducto = new PictureBox();
            btnFoto = new Button();
            btnAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 79);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 82);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 417);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 211);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 4;
            label5.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 146);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 5;
            label6.Text = "Foto:";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(128, 79);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(305, 31);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(135, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(47, 259);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(386, 112);
            txtDescripcion.TabIndex = 8;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(578, 80);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 31);
            nudStock.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(117, 417);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(316, 31);
            txtPrecio.TabIndex = 10;
            // 
            // pbProducto
            // 
            pbProducto.Location = new Point(502, 186);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(256, 200);
            pbProducto.TabIndex = 11;
            pbProducto.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(561, 146);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(197, 34);
            btnFoto.TabIndex = 12;
            btnFoto.Text = "Seleccionar foto.";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(502, 417);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(256, 34);
            btnAgregarProducto.TabIndex = 13;
            btnAgregarProducto.Text = "Agregar Producto.";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 131, 133);
            ClientSize = new Size(795, 484);
            Controls.Add(btnAgregarProducto);
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
            Name = "FrmAgregarProducto";
            Text = "FrmActualizarProducto";
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
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nudStock;
        private TextBox txtPrecio;
        private PictureBox pbProducto;
        private Button btnFoto;
        private Button btnAgregarProducto;
    }
}