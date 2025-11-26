namespace ProyectoFinal.Frontend
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dvgProductos = new DataGridView();
            pnlApp = new Panel();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            pnlApp.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregar.CausesValidation = false;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(10, 550);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 86);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(136, 99, 75);
            btnEliminar.CausesValidation = false;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(441, 544);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 92);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(136, 99, 75);
            btnActualizar.CausesValidation = false;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(824, 550);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(163, 86);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dvgProductos
            // 
            dvgProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgProductos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dvgProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dvgProductos.Location = new Point(0, 0);
            dvgProductos.Margin = new Padding(2);
            dvgProductos.Name = "dvgProductos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvgProductos.RowHeadersVisible = false;
            dvgProductos.RowHeadersWidth = 62;
            dvgProductos.ScrollBars = ScrollBars.None;
            dvgProductos.Size = new Size(987, 515);
            dvgProductos.TabIndex = 13;
            dvgProductos.CellContentClick += dvgProductos_CellContentClick;
            // 
            // pnlApp
            // 
            pnlApp.Controls.Add(dvgProductos);
            pnlApp.Location = new Point(10, 10);
            pnlApp.Margin = new Padding(2);
            pnlApp.Name = "pnlApp";
            pnlApp.Size = new Size(636, 387);
            pnlApp.TabIndex = 14;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1008, 647);
            Controls.Add(pnlApp);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            pnlApp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dvgProductos;
        private Panel pnlApp;
    }
}