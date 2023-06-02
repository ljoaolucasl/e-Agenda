using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TabelaDespesaControl : UserControl, ITabelaBase<Despesa>
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            gridDespesa.ConfigurarTabelaGrid(new string[] { "Número", "Descrição", "Valor", "Data", "Forma Pgmto" });
        }

        public DataGridView DataGridView => gridDespesa;

        public void AtualizarLista(List<Despesa> despesas)
        {
            gridDespesa.Rows.Clear();

            foreach (Despesa item in despesas)
            {
                DataGridViewRow row = new();

                row.CreateCells(gridDespesa, item.id, item.descricao, item.valor, item.data, item.formaPagamento);

                row.Cells[0].Tag = item;

                gridDespesa.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {despesas.Count} Despesas");
        }

        public Despesa? ObterTarefaSelecionada()
        {
            return (Despesa)gridDespesa.SelectedRows[0].Cells[0].Tag;
        }
    }
}
