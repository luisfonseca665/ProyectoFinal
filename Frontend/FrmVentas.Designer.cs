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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.Location = new Point(408, 22);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
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
            cboEmpleados.Location = new Point(560, 22);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(406, 31);
            cboEmpleados.TabIndex = 3;
            // 
            // dgvVenta
            // 
            dgvVenta.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.GridColor = Color.Black;
            dgvVenta.Location = new Point(24, 298);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(942, 192);
            dgvVenta.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(136, 99, 75);
            btnConfirmar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(766, 507);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(200, 44);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnCobrar_Click;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txtTotal.Location = new Point(622, 514);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(106, 32);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "DINERO";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(24, 69);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(942, 223);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(136, 99, 75);
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 507);
            button1.Name = "button1";
            button1.Size = new Size(170, 44);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label3.Location = new Point(496, 514);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 13;
            label3.Text = "TOTAL:";
            label3.Click += label3_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(990, 600);
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