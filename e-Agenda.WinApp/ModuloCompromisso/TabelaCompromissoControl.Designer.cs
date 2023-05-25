namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TabelaCompromissoControl
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
            gridCompromisso = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCompromisso).BeginInit();
            SuspendLayout();
            // 
            // gridCompromisso
            // 
            gridCompromisso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCompromisso.Location = new Point(282, 169);
            gridCompromisso.Name = "gridCompromisso";
            gridCompromisso.Size = new Size(240, 150);
            gridCompromisso.TabIndex = 0;
            // 
            // TabelaCompromissoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCompromisso);
            Name = "TabelaCompromissoControl";
            Size = new Size(862, 501);
            ((System.ComponentModel.ISupportInitialize)gridCompromisso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCompromisso;
    }
}
