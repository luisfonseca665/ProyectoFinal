namespace ProyectoFinal.Frontend
{
    partial class ProductoCardControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picFoto = new PictureBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            numCantidad = new NumericUpDown();
            btnReset = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // picFoto
            // 
            picFoto.Location = new Point(31, 3);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(125, 119);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(8, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(31, 145);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(104, 143);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(52, 27);
            numCantidad.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.IndianRed;
            btnReset.Location = new Point(31, 176);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "X";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.GreenYellow;
            btnAgregar.Location = new Point(78, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ProductoCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAgregar);
            Controls.Add(btnReset);
            Controls.Add(numCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(picFoto);
            Name = "ProductoCardControl";
            Size = new Size(186, 209);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFoto;
        private Label lblNombre;
        private Label lblPrecio;
        private NumericUpDown numCantidad;
        private Button btnReset;
        private Button btnAgregar;
    }
}
