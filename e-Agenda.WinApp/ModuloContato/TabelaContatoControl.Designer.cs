namespace e_Agenda.WinApp.ModuloContato
{
    partial class TabelaContatoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridContato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridContato).BeginInit();
            SuspendLayout();
            // 
            // gridContato
            // 
            gridContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContato.Location = new Point(246, 140);
            gridContato.Name = "gridContato";
            gridContato.RowTemplate.Height = 25;
            gridContato.Size = new Size(240, 150);
            gridContato.TabIndex = 0;
            // 
            // TabelaContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridContato);
            Name = "TabelaContatoControl";
            Size = new Size(857, 497);
            ((System.ComponentModel.ISupportInitialize)gridContato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridContato;
    }
}
