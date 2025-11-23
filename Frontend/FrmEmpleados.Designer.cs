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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            TablaEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TablaEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(136, 99, 75);
            btnModificar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(519, 426);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 86);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(136, 99, 75);
            btnEliminar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(281, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 86);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(136, 99, 75);
            btnAgregar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(21, 426);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 86);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // TablaEmpleados
            // 
            TablaEmpleados.BackgroundColor = Color.FromArgb(255, 224, 192);
            TablaEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaEmpleados.Location = new Point(21, 21);
            TablaEmpleados.Name = "TablaEmpleados";
            TablaEmpleados.RowHeadersWidth = 51;
            TablaEmpleados.Size = new Size(623, 360);
            TablaEmpleados.TabIndex = 3;
            // 
            // FrmEmpleados
            // 
            ClientSize = new Size(536, 336);
            Name = "FrmEmpleados";
            ((System.ComponentModel.ISupportInitialize)TablaEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView TablaEmpleados;
    }
}