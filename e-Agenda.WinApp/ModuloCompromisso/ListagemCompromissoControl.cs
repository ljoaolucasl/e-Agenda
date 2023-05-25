using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl, ITabelaBase<Compromisso>
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView { get; }

        public void AtualizarLista(List<Compromisso> compromissos)
        {
            listCompromissos.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                ListViewItem item = new ListViewItem(compromisso.id.ToString());
                item.SubItems.Add(compromisso.assunto);
                item.SubItems.Add(compromisso.data);
                item.SubItems.Add(compromisso.inicio);
                item.SubItems.Add(compromisso.final);
                item.SubItems.Add(compromisso.contato == null ? "" : compromisso.contato.Nome);
                item.Tag = compromisso;
                listCompromissos.Items.Add(item);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {compromissos.Count} Compromissos");
        }

        public Compromisso? ObterTarefaSelecionada()
        {
            ListViewItem itemSelecionado = listCompromissos.SelectedItems[0];
            return listCompromissos.SelectedItems.Count > 0 ? (Compromisso)itemSelecionado.Tag : null;
        }
    }
}
