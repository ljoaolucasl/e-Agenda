using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl, ITabelaBase<Compromisso>
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            gridCompromisso.ConfigurarTabelaGrid(new string[] { "Número", "Assunto", "Data", "Hora Início", "Hora Final", "Contato" });
        }

        public DataGridView DataGridView => gridCompromisso;

        public void AtualizarLista(List<Compromisso> compromissos)
        {
            gridCompromisso.Rows.Clear();

            foreach (Compromisso item in compromissos)
            {
                DataGridViewRow row = new();

                row.CreateCells(gridCompromisso, item.id, item.assunto, item.data, item.inicio, item.final, item.contato == null ? "" : item.contato.Nome);

                row.Cells[0].Tag = item;

                gridCompromisso.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {compromissos.Count} Compromissos");
        }

        public Compromisso? ObterTarefaSelecionada()
        {
            return (Compromisso)gridCompromisso.SelectedRows[0].Cells[0].Tag;
        }
    }
}
