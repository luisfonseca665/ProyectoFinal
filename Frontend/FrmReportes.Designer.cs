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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            chGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpMes1 = new DateTimePicker();
            btnAceptar = new Button();
            dtpMes2 = new DateTimePicker();
            btnexpo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            tabControl1.SuspendLayout();
            tbpVentasProducto.SuspendLayout();
            tbpComparativo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chGrafica).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.Location = new Point(322, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
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
            dtpInicio.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(144, 92);
            dtpInicio.Margin = new Padding(4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(154, 31);
            dtpInicio.TabIndex = 2;
            // 
            // dtpFin
            // 
            dtpFin.CalendarMonthBackground = Color.FromArgb(136, 99, 75);
            dtpFin.CalendarTitleBackColor = Color.FromArgb(136, 99, 75);
            dtpFin.CalendarTrailingForeColor = Color.Black;
            dtpFin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(430, 95);
            dtpFin.Margin = new Padding(4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(156, 31);
            dtpFin.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(136, 99, 75);
            btnGenerar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(606, 92);
            btnGenerar.Margin = new Padding(4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(164, 45);
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
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(24, 145);
            dgvReporte.Margin = new Padding(4);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(746, 386);
            dgvReporte.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(136, 99, 75);
            label3.Location = new Point(102, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(570, 48);
            label3.TabIndex = 6;
            label3.Text = "Reporte de venta por producto";
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(136, 99, 75);
            btnExcel.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(621, 539);
            btnExcel.Margin = new Padding(4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(149, 42);
            btnExcel.TabIndex = 7;
            btnExcel.Text = "Exportar";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpVentasProducto);
            tabControl1.Controls.Add(tbpComparativo);
            tabControl1.Location = new Point(2, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(804, 626);
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
            tbpVentasProducto.Location = new Point(4, 34);
            tbpVentasProducto.Margin = new Padding(4);
            tbpVentasProducto.Name = "tbpVentasProducto";
            tbpVentasProducto.Padding = new Padding(4);
            tbpVentasProducto.Size = new Size(796, 588);
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
            tbpComparativo.Location = new Point(4, 34);
            tbpComparativo.Margin = new Padding(4);
            tbpComparativo.Name = "tbpComparativo";
            tbpComparativo.Padding = new Padding(4);
            tbpComparativo.Size = new Size(796, 588);
            tbpComparativo.TabIndex = 1;
            tbpComparativo.Text = "Reporte Comparativo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(chGrafica);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(4, 161);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(788, 423);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // chGrafica
            // 
            chartArea1.Name = "ChartArea1";
            chGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chGrafica.Legends.Add(legend1);
            chGrafica.Location = new Point(3, 3);
            chGrafica.Name = "chGrafica";
            chGrafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chGrafica.Series.Add(series1);
            chGrafica.Size = new Size(789, 417);
            chGrafica.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(136, 99, 75);
            label4.Location = new Point(70, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(401, 48);
            label4.TabIndex = 12;
            label4.Text = "Reporte Comparativo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label5.Location = new Point(70, 99);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 7;
            label5.Text = "Mes 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label6.Location = new Point(354, 100);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
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
            dtpMes1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            dtpMes1.Format = DateTimePickerFormat.Custom;
            dtpMes1.Location = new Point(147, 94);
            dtpMes1.Margin = new Padding(4);
            dtpMes1.Name = "dtpMes1";
            dtpMes1.Size = new Size(154, 31);
            dtpMes1.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(136, 99, 75);
            btnAceptar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(609, 94);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 45);
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
            dtpMes2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            dtpMes2.Format = DateTimePickerFormat.Short;
            dtpMes2.Location = new Point(433, 97);
            dtpMes2.Margin = new Padding(4);
            dtpMes2.Name = "dtpMes2";
            dtpMes2.Size = new Size(156, 31);
            dtpMes2.TabIndex = 10;
            // 
            // btnexpo
            // 
            btnexpo.BackColor = Color.FromArgb(136, 99, 75);
            btnexpo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnexpo.ForeColor = Color.White;
            btnexpo.Location = new Point(609, 27);
            btnexpo.Margin = new Padding(4);
            btnexpo.Name = "btnexpo";
            btnexpo.Size = new Size(164, 45);
            btnexpo.TabIndex = 13;
            btnexpo.Text = "Exportar";
            btnexpo.UseVisualStyleBackColor = false;
            btnexpo.Click += btnexpo_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(815, 644);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "FrmReportes";
            Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            tabControl1.ResumeLayout(false);
            tbpVentasProducto.ResumeLayout(false);
            tbpVentasProducto.PerformLayout();
            tbpComparativo.ResumeLayout(false);
            tbpComparativo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chGrafica).EndInit();
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