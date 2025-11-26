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
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label1.Location = new Point(29, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label2.Location = new Point(29, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label3.Location = new Point(502, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label4.Location = new Point(29, 382);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 30);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label5.Location = new Point(29, 186);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 30);
            label5.TabIndex = 4;
            label5.Text = "Descripcion:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label6.Location = new Point(502, 109);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 30);
            label6.TabIndex = 5;
            label6.Text = "Foto:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(136, 99, 75);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(128, 48);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(313, 34);
            txtCodigo.TabIndex = 6;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(136, 99, 75);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(141, 109);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 34);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(136, 99, 75);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(29, 234);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(412, 112);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(136, 99, 75);
            nudStock.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(584, 52);
            nudStock.Margin = new Padding(2);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(175, 34);
            nudStock.TabIndex = 9;
            nudStock.ValueChanged += nudStock_ValueChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(136, 99, 75);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(118, 380);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(323, 34);
            txtPrecio.TabIndex = 10;
            // 
            // pbProducto
            // 
            pbProducto.Location = new Point(502, 151);
            pbProducto.Margin = new Padding(2);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(256, 200);
            pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProducto.TabIndex = 11;
            pbProducto.TabStop = false;
            pbProducto.Click += pbProducto_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.FromArgb(136, 99, 75);
            btnFoto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnFoto.Location = new Point(582, 104);
            btnFoto.Margin = new Padding(2);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(176, 42);
            btnFoto.TabIndex = 12;
            btnFoto.Text = "Seleccionar foto.";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregarProducto.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnAgregarProducto.Location = new Point(502, 375);
            btnAgregarProducto.Margin = new Padding(2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(256, 42);
            btnAgregarProducto.TabIndex = 13;
            btnAgregarProducto.Text = "Agregar Producto.";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
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