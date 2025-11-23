namespace ProyectoFinal.Frontend
{
    partial class FrmVentas
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
            txtCodigo = new TextBox();
            label2 = new Label();
            cboEmpleados = new ComboBox();
            btnAgregar = new Button();
            numCantidad = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            dgvVenta = new DataGridView();
            btnCobrar = new Button();
            txtTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro de ventas";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(110, 122);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(105, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleado:";
            // 
            // cboEmpleados
            // 
            cboEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(110, 81);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(240, 28);
            cboEmpleados.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(544, 123);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(299, 123);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(51, 27);
            numCantidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 125);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 125);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Codigo:";
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(24, 165);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(614, 257);
            dgvVenta.TabIndex = 8;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(544, 427);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(94, 31);
            btnCobrar.TabIndex = 9;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(24, 432);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(45, 20);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "Total:";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(658, 472);
            Controls.Add(txtTotal);
            Controls.Add(btnCobrar);
            Controls.Add(dgvVenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(cboEmpleados);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "FrmVentas";
            Text = "FrmVentas";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private ComboBox cboEmpleados;
        private Button btnAgregar;
        private NumericUpDown numCantidad;
        private Label label3;
        private Label label4;
        private DataGridView dgvVenta;
        private Button btnCobrar;
        private Label txtTotal;
    }
}