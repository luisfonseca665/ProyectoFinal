namespace ProyectoFinal.Frontend
{
    partial class FrmAuditoria
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
            dvgAuditorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgAuditorias).BeginInit();
            SuspendLayout();
            // 
            // dvgAuditorias
            // 
            dvgAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAuditorias.Location = new Point(31, 104);
            dvgAuditorias.Name = "dvgAuditorias";
            dvgAuditorias.RowHeadersWidth = 62;
            dvgAuditorias.Size = new Size(739, 324);
            dvgAuditorias.TabIndex = 0;
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgAuditorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAuditoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAuditoria";
            Load += FrmAuditoria_Load;
            ((System.ComponentModel.ISupportInitialize)dvgAuditorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgAuditorias;
    }
}