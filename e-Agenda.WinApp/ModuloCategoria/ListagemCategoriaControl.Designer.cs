namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class ListagemCategoriaControl
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
            listCategorias = new ListView();
            columnId = new ColumnHeader();
            columnTitulo = new ColumnHeader();
            SuspendLayout();
            // 
            // listCategorias
            // 
            listCategorias.Columns.AddRange(new ColumnHeader[] { columnId, columnTitulo });
            listCategorias.Dock = DockStyle.Fill;
            listCategorias.FullRowSelect = true;
            listCategorias.GridLines = true;
            listCategorias.Location = new Point(0, 0);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(926, 531);
            listCategorias.TabIndex = 1;
            listCategorias.UseCompatibleStateImageBehavior = false;
            listCategorias.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            // 
            // columnTitulo
            // 
            columnTitulo.Text = "Título";
            columnTitulo.Width = 860;
            // 
            // ListagemCategoriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listCategorias);
            Name = "ListagemCategoriaControl";
            Size = new Size(926, 531);
            ResumeLayout(false);
        }

        #endregion
        private ListView listCategorias;
        private ColumnHeader columnId;
        private ColumnHeader columnTitulo;
    }
}
