namespace ProyectoFinal.Frontend
{
    partial class FrmReportes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            btnGenerar = new Button();
            dgvReporte = new DataGridView();
            label3 = new Label();
            btnExcel = new Button();
            tabControl1 = new TabControl();
            tbpVentasProducto = new TabPage();
            tbpComparativo = new TabPage();
            btnexpo = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpMes1 = new DateTimePicker();
            btnAceptar = new Button();
            dtpMes2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            tabControl1.SuspendLayout();
            tbpVentasProducto.SuspendLayout();
            tbpComparativo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.Location = new Point(407, 72);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 1;
            label2.Text = "Fecha Fin:";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarForeColor = Color.White;
            dtpInicio.CalendarMonthBackground = Color.White;
            dtpInicio.CalendarTitleBackColor = Color.FromArgb(136, 99, 75);
            dtpInicio.CalendarTitleForeColor = Color.FromArgb(136, 99, 75);
            dtpInicio.CalendarTrailingForeColor = Color.FromArgb(136, 99, 75);
            dtpInicio.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(166, 72);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(235, 34);
            dtpInicio.TabIndex = 2;
            // 
            // dtpFin
            // 
            dtpFin.CalendarMonthBackground = Color.FromArgb(136, 99, 75);
            dtpFin.CalendarTitleBackColor = Color.FromArgb(136, 99, 75);
            dtpFin.CalendarTrailingForeColor = Color.Black;
            dtpFin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(543, 69);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(224, 34);
            dtpFin.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(136, 99, 75);
            btnGenerar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(796, 65);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(131, 45);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(19, 116);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(916, 360);
            dgvReporte.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(136, 99, 75);
            label3.Location = new Point(176, 3);
            label3.Name = "label3";
            label3.Size = new Size(538, 46);
            label3.TabIndex = 6;
            label3.Text = "Reporte de venta por producto";
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(136, 99, 75);
            btnExcel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(796, 482);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(139, 41);
            btnExcel.TabIndex = 7;
            btnExcel.Text = "Exportar";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpVentasProducto);
            tabControl1.Controls.Add(tbpComparativo);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(959, 562);
            tabControl1.TabIndex = 8;
            // 
            // tbpVentasProducto
            // 
            tbpVentasProducto.BackColor = Color.FromArgb(255, 224, 192);
            tbpVentasProducto.Controls.Add(label3);
            tbpVentasProducto.Controls.Add(btnExcel);
            tbpVentasProducto.Controls.Add(label1);
            tbpVentasProducto.Controls.Add(label2);
            tbpVentasProducto.Controls.Add(dgvReporte);
            tbpVentasProducto.Controls.Add(dtpInicio);
            tbpVentasProducto.Controls.Add(btnGenerar);
            tbpVentasProducto.Controls.Add(dtpFin);
            tbpVentasProducto.Location = new Point(4, 29);
            tbpVentasProducto.Name = "tbpVentasProducto";
            tbpVentasProducto.Padding = new Padding(3, 3, 3, 3);
            tbpVentasProducto.Size = new Size(951, 529);
            tbpVentasProducto.TabIndex = 0;
            tbpVentasProducto.Text = "Ventas por producto";
            // 
            // tbpComparativo
            // 
            tbpComparativo.BackColor = Color.FromArgb(255, 224, 192);
            tbpComparativo.Controls.Add(btnexpo);
            tbpComparativo.Controls.Add(flowLayoutPanel1);
            tbpComparativo.Controls.Add(label4);
            tbpComparativo.Controls.Add(label5);
            tbpComparativo.Controls.Add(label6);
            tbpComparativo.Controls.Add(dtpMes1);
            tbpComparativo.Controls.Add(btnAceptar);
            tbpComparativo.Controls.Add(dtpMes2);
            tbpComparativo.Location = new Point(4, 29);
            tbpComparativo.Name = "tbpComparativo";
            tbpComparativo.Padding = new Padding(3, 3, 3, 3);
            tbpComparativo.Size = new Size(951, 529);
            tbpComparativo.TabIndex = 1;
            tbpComparativo.Text = "Reporte Comparativo";
            // 
            // btnexpo
            // 
            btnexpo.BackColor = Color.FromArgb(136, 99, 75);
            btnexpo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnexpo.ForeColor = Color.White;
            btnexpo.Location = new Point(765, 88);
            btnexpo.Name = "btnexpo";
            btnexpo.Size = new Size(180, 38);
            btnexpo.TabIndex = 13;
            btnexpo.Text = "Exportar";
            btnexpo.UseVisualStyleBackColor = false;
            btnexpo.Click += btnexpo_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(3, 188);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(945, 338);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(136, 99, 75);
            label4.Location = new Point(56, 15);
            label4.Name = "label4";
            label4.Size = new Size(411, 50);
            label4.TabIndex = 12;
            label4.Text = "Reporte Comparativo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label5.Location = new Point(35, 104);
            label5.Name = "label5";
            label5.Size = new Size(90, 32);
            label5.TabIndex = 7;
            label5.Text = "Mes 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label6.Location = new Point(373, 104);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 8;
            label6.Text = "Mes 2:";
            // 
            // dtpMes1
            // 
            dtpMes1.CalendarForeColor = Color.White;
            dtpMes1.CalendarMonthBackground = Color.White;
            dtpMes1.CalendarTitleBackColor = Color.FromArgb(136, 99, 75);
            dtpMes1.CalendarTitleForeColor = Color.FromArgb(136, 99, 75);
            dtpMes1.CalendarTrailingForeColor = Color.FromArgb(136, 99, 75);
            dtpMes1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dtpMes1.Format = DateTimePickerFormat.Custom;
            dtpMes1.Location = new Point(140, 101);
            dtpMes1.Name = "dtpMes1";
            dtpMes1.Size = new Size(227, 34);
            dtpMes1.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(136, 99, 75);
            btnAceptar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(765, 147);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(180, 36);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Generar Reporte";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dtpMes2
            // 
            dtpMes2.CalendarMonthBackground = Color.FromArgb(136, 99, 75);
            dtpMes2.CalendarTitleBackColor = Color.FromArgb(136, 99, 75);
            dtpMes2.CalendarTrailingForeColor = Color.Black;
            dtpMes2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dtpMes2.Format = DateTimePickerFormat.Short;
            dtpMes2.Location = new Point(471, 101);
            dtpMes2.Name = "dtpMes2";
            dtpMes2.Size = new Size(210, 34);
            dtpMes2.TabIndex = 10;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(990, 600);
            Controls.Add(tabControl1);
            Name = "FrmReportes";
            Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            tabControl1.ResumeLayout(false);
            tbpVentasProducto.ResumeLayout(false);
            tbpVentasProducto.PerformLayout();
            tbpComparativo.ResumeLayout(false);
            tbpComparativo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Button btnGenerar;
        private DataGridView dgvReporte;
        private Label label3;
        private Button btnExcel;
        private TabControl tabControl1;
        private TabPage tbpVentasProducto;
        private TabPage tbpComparativo;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpMes1;
        private Button btnAceptar;
        private DateTimePicker dtpMes2;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafica;
        private Button btnexpo;
    }
}