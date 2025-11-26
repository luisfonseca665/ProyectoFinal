namespace ProyectoFinal.Frontend
{
    partial class FrmEmpleados
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            pnlApp = new Panel();
            dvgEmpleados = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            pnlApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // pnlApp
            // 
            pnlApp.Controls.Add(dvgEmpleados);
            pnlApp.Location = new Point(11, 11);
            pnlApp.Margin = new Padding(2);
            pnlApp.Name = "pnlApp";
            pnlApp.Size = new Size(779, 460);
            pnlApp.TabIndex = 18;
            // 
            // dvgEmpleados
            // 
            dvgEmpleados.BackgroundColor = Color.FromArgb(255, 224, 192);
            dvgEmpleados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dvgEmpleados.Dock = DockStyle.Fill;
            dvgEmpleados.Location = new Point(0, 0);
            dvgEmpleados.Margin = new Padding(2);
            dvgEmpleados.Name = "dvgEmpleados";
            dvgEmpleados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvgEmpleados.RowHeadersVisible = false;
            dvgEmpleados.RowHeadersWidth = 62;
            dvgEmpleados.ScrollBars = ScrollBars.None;
            dvgEmpleados.Size = new Size(779, 460);
            dvgEmpleados.TabIndex = 13;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(136, 99, 75);
            btnActualizar.CausesValidation = false;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(626, 488);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(172, 108);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(136, 99, 75);
            btnEliminar.CausesValidation = false;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(319, 488);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(164, 108);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregar.CausesValidation = false;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(11, 488);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 108);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(801, 602);
            Controls.Add(pnlApp);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Load += FrmEmpleados_Load;
            pnlApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlApp;
        private DataGridView dvgEmpleados;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}