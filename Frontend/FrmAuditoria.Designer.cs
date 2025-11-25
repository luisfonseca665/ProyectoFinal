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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dvgAuditorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgAuditorias).BeginInit();
            SuspendLayout();
            // 
            // dvgAuditorias
            // 
            dvgAuditorias.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(136, 99, 75);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgAuditorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAuditorias.Location = new Point(25, 83);
            dvgAuditorias.Margin = new Padding(2);
            dvgAuditorias.Name = "dvgAuditorias";
            dvgAuditorias.RowHeadersWidth = 62;
            dvgAuditorias.Size = new Size(591, 259);
            dvgAuditorias.TabIndex = 0;
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(640, 360);
            Controls.Add(dvgAuditorias);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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