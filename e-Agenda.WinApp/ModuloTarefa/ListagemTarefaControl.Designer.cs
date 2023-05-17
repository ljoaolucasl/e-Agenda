namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class ListagemTarefaControl
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
            listTarefas = new ListView();
            columnId = new ColumnHeader();
            columnTitulo = new ColumnHeader();
            columnPrioridade = new ColumnHeader();
            SuspendLayout();
            // 
            // listTarefas
            // 
            listTarefas.Columns.AddRange(new ColumnHeader[] { columnId, columnTitulo, columnPrioridade });
            listTarefas.Dock = DockStyle.Fill;
            listTarefas.FullRowSelect = true;
            listTarefas.GridLines = true;
            listTarefas.Location = new Point(0, 0);
            listTarefas.Name = "listTarefas";
            listTarefas.Size = new Size(925, 544);
            listTarefas.TabIndex = 2;
            listTarefas.UseCompatibleStateImageBehavior = false;
            listTarefas.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            // 
            // columnTitulo
            // 
            columnTitulo.Text = "Título";
            columnTitulo.Width = 500;
            // 
            // columnPrioridade
            // 
            columnPrioridade.Text = "Prioridade";
            columnPrioridade.Width = 100;
            // 
            // ListagemTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefas);
            Name = "ListagemTarefaControl";
            Size = new Size(925, 544);
            ResumeLayout(false);
        }

        #endregion

        private ListView listTarefas;
        private ColumnHeader columnId;
        private ColumnHeader columnTitulo;
        private ColumnHeader columnPrioridade;
    }
}
