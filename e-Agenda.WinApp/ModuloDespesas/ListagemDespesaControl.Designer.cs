namespace e_Agenda.WinApp.ModuloDespesas
{
    partial class ListagemDespesaControl
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
            listDespesas = new ListView();
            columnId = new ColumnHeader();
            columnDescricao = new ColumnHeader();
            columnValor = new ColumnHeader();
            columnData = new ColumnHeader();
            columnPagamento = new ColumnHeader();
            columnCategoria = new ColumnHeader();
            SuspendLayout();
            // 
            // listDespesas
            // 
            listDespesas.Columns.AddRange(new ColumnHeader[] { columnId, columnDescricao, columnValor, columnData, columnPagamento, columnCategoria });
            listDespesas.Dock = DockStyle.Fill;
            listDespesas.FullRowSelect = true;
            listDespesas.GridLines = true;
            listDespesas.Location = new Point(0, 0);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(926, 531);
            listDespesas.TabIndex = 1;
            listDespesas.UseCompatibleStateImageBehavior = false;
            listDespesas.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            // 
            // columnDescricao
            // 
            columnDescricao.Text = "Descrição";
            columnDescricao.Width = 200;
            // 
            // columnValor
            // 
            columnValor.Text = "Valor (R$)";
            columnValor.Width = 170;
            // 
            // columnData
            // 
            columnData.Text = "Data";
            columnData.Width = 170;
            // 
            // columnPagamento
            // 
            columnPagamento.Text = "Forma de Pagamento";
            columnPagamento.Width = 160;
            // 
            // columnCategoria
            // 
            columnCategoria.Text = "Categoria";
            columnCategoria.Width = 160;
            // 
            // ListagemDespesaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listDespesas);
            Name = "ListagemDespesaControl";
            Size = new Size(926, 531);
            ResumeLayout(false);
        }

        #endregion
        private ListView listDespesas;
        private ColumnHeader columnId;
        private ColumnHeader columnDescricao;
        private ColumnHeader columnValor;
        private ColumnHeader columnData;
        private ColumnHeader columnPagamento;
        private ColumnHeader columnCategoria;
    }
}
