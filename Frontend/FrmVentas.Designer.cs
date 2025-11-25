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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(299, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 2;
            label2.Text = "Empleado:";
            // 
            // cboEmpleados
            // 
            cboEmpleados.BackColor = Color.FromArgb(136, 99, 75);
            cboEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleados.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            cboEmpleados.ForeColor = Color.White;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(398, 20);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(240, 31);
            cboEmpleados.TabIndex = 3;
            // 
            // dgvVenta
            // 
            dgvVenta.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.GridColor = Color.Black;
            dgvVenta.Location = new Point(24, 285);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(614, 192);
            dgvVenta.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(136, 99, 75);
            btnConfirmar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(544, 483);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 31);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnCobrar_Click;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            txtTotal.Location = new Point(445, 486);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(77, 23);
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
            button1.BackColor = Color.FromArgb(136, 99, 75);
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 483);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.Location = new Point(367, 486);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 13;
            label3.Text = "TOTAL:";
            label3.Click += label3_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(658, 516);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtTotal);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvVenta);
            Controls.Add(cboEmpleados);
            Controls.Add(label2);
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