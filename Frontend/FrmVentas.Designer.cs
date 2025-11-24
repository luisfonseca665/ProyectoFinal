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
            label2 = new Label();
            cboEmpleados = new ComboBox();
            dgvVenta = new DataGridView();
            btnConfirmar = new Button();
            txtTotal = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro de ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 25);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleado:";
            // 
            // cboEmpleados
            // 
            cboEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(385, 22);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(240, 28);
            cboEmpleados.TabIndex = 3;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(24, 285);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(614, 192);
            dgvVenta.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(544, 483);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 31);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnCobrar_Click;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(436, 488);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(63, 20);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "DINERO";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(24, 69);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(614, 210);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(24, 483);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 488);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 13;
            label3.Text = "TOTAL:";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(658, 516);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtTotal);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvVenta);
            Controls.Add(cboEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVentas";
            Text = "FrmVentas";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboEmpleados;
        private DataGridView dgvVenta;
        private Button btnConfirmar;
        private Label txtTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label3;
    }
}