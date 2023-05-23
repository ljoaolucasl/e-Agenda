using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl, IListagemBase<Compromisso>
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public ListView ListView { get { return listCompromissos; } }

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
                item.SubItems.Add(compromisso.contato == null ? "" : compromisso.contato.nome);
                item.Tag = compromisso;
                listCompromissos.Items.Add(item);
            }
        }

        public Compromisso? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listCompromissos.SelectedItems[0];
            return listCompromissos.SelectedItems.Count > 0 ? (Compromisso)itemSelecionado.Tag : null;
        }
    }
}
