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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 48);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 0;
            label7.Text = "Nombre: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 100);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 1;
            label8.Text = "Apellidos: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 154);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 2;
            label9.Text = "Teléfono: ";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 198);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 3;
            label10.Text = "Correo: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(462, 58);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 4;
            label11.Text = "Tipo: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(55, 286);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 5;
            label12.Text = "Contraseña: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(55, 244);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 6;
            label13.Text = "Usuario: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(145, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 242);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(145, 283);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(257, 27);
            textBox6.TabIndex = 12;
            // 
            // FrmEditarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 131, 133);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "FrmEditarEmpleados";
            Text = "FrmEditarEmpleados";
            Load += FrmEditarEmpleados_Load;
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}