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
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            tabControl1.SuspendLayout();
            tbpVentasProducto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha Fin:";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(115, 74);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(124, 27);
            dtpInicio.TabIndex = 2;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(324, 75);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(126, 27);
            dtpFin.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(485, 76);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(131, 29);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(19, 116);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(597, 309);
            dgvReporte.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 17);
            label3.Name = "label3";
            label3.Size = new Size(423, 38);
            label3.TabIndex = 6;
            label3.Text = "Reporte de venta por producto";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(522, 431);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 29);
            btnExcel.TabIndex = 7;
            btnExcel.Text = "Exportar";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpVentasProducto);
            tabControl1.Controls.Add(tbpComparativo);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(643, 501);
            tabControl1.TabIndex = 8;
            // 
            // tbpVentasProducto
            // 
            tbpVentasProducto.BackColor = Color.Wheat;
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
            tbpVentasProducto.Padding = new Padding(3);
            tbpVentasProducto.Size = new Size(635, 468);
            tbpVentasProducto.TabIndex = 0;
            tbpVentasProducto.Text = "Ventas por producto";
            // 
            // tbpComparativo
            // 
            tbpComparativo.BackColor = Color.Wheat;
            tbpComparativo.Location = new Point(4, 29);
            tbpComparativo.Name = "tbpComparativo";
            tbpComparativo.Padding = new Padding(3);
            tbpComparativo.Size = new Size(635, 468);
            tbpComparativo.TabIndex = 1;
            tbpComparativo.Text = "Reporte Comparativo";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(652, 515);
            Controls.Add(tabControl1);
            Name = "FrmReportes";
            Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            tabControl1.ResumeLayout(false);
            tbpVentasProducto.ResumeLayout(false);
            tbpVentasProducto.PerformLayout();
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
    }
}