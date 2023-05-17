namespace e_Agenda.WinApp.ModuloContato
{
    partial class ListagemContatoControl
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
            listContatos = new ListView();
            columnId = new ColumnHeader();
            columnNome = new ColumnHeader();
            columnTelefone = new ColumnHeader();
            columnEmail = new ColumnHeader();
            columnCargo = new ColumnHeader();
            columnEmpresa = new ColumnHeader();
            SuspendLayout();
            // 
            // listContatos
            // 
            listContatos.Columns.AddRange(new ColumnHeader[] { columnId, columnNome, columnTelefone, columnEmail, columnCargo, columnEmpresa });
            listContatos.Dock = DockStyle.Fill;
            listContatos.FullRowSelect = true;
            listContatos.GridLines = true;
            listContatos.Location = new Point(0, 0);
            listContatos.Name = "listContatos";
            listContatos.Size = new Size(926, 531);
            listContatos.TabIndex = 1;
            listContatos.UseCompatibleStateImageBehavior = false;
            listContatos.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            // 
            // columnNome
            // 
            columnNome.Text = "Nome";
            columnNome.Width = 200;
            // 
            // columnTelefone
            // 
            columnTelefone.Text = "Telefone";
            columnTelefone.Width = 170;
            // 
            // columnEmail
            // 
            columnEmail.Text = "E-mail";
            columnEmail.Width = 170;
            // 
            // columnCargo
            // 
            columnCargo.Text = "Cargo";
            columnCargo.Width = 160;
            // 
            // columnEmpresa
            // 
            columnEmpresa.Text = "Empresa";
            columnEmpresa.Width = 160;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContatos);
            Name = "ListagemContatoControl";
            Size = new Size(926, 531);
            ResumeLayout(false);
        }

        #endregion
        private ListView listContatos;
        private ColumnHeader columnId;
        private ColumnHeader columnNome;
        private ColumnHeader columnTelefone;
        private ColumnHeader columnEmail;
        private ColumnHeader columnCargo;
        private ColumnHeader columnEmpresa;
    }
}
