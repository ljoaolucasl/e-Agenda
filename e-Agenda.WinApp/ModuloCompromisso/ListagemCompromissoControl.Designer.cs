namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class ListagemCompromissoControl
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
            listCompromissos = new ListView();
            columnId = new ColumnHeader();
            columnAssunto = new ColumnHeader();
            columnData = new ColumnHeader();
            columnComeca = new ColumnHeader();
            columnTermina = new ColumnHeader();
            columnContato = new ColumnHeader();
            SuspendLayout();
            // 
            // listCompromissos
            // 
            listCompromissos.Columns.AddRange(new ColumnHeader[] { columnId, columnAssunto, columnData, columnComeca, columnTermina, columnContato });
            listCompromissos.Dock = DockStyle.Fill;
            listCompromissos.FullRowSelect = true;
            listCompromissos.GridLines = true;
            listCompromissos.Location = new Point(0, 0);
            listCompromissos.Name = "listCompromissos";
            listCompromissos.Size = new Size(817, 494);
            listCompromissos.TabIndex = 2;
            listCompromissos.UseCompatibleStateImageBehavior = false;
            listCompromissos.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            // 
            // columnAssunto
            // 
            columnAssunto.Text = "Assunto";
            columnAssunto.Width = 250;
            // 
            // columnData
            // 
            columnData.Text = "Data";
            columnData.Width = 120;
            // 
            // columnComeca
            // 
            columnComeca.Text = "Começa às";
            columnComeca.Width = 110;
            // 
            // columnTermina
            // 
            columnTermina.Text = "Termina às";
            columnTermina.Width = 110;
            // 
            // columnContato
            // 
            columnContato.Text = "Contato";
            columnContato.Width = 160;
            // 
            // ListagemCompromissoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listCompromissos);
            Name = "ListagemCompromissoControl";
            Size = new Size(817, 494);
            ResumeLayout(false);
        }

        #endregion

        private ListView listCompromissos;
        private ColumnHeader columnId;
        private ColumnHeader columnAssunto;
        private ColumnHeader columnData;
        private ColumnHeader columnComeca;
        private ColumnHeader columnTermina;
        private ColumnHeader columnContato;
    }
}
