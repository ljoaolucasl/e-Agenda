using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl, IListagemBase<Contato>
    {
        public ListagemContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                ListViewItem item = new ListViewItem(contato.id.ToString());
                item.SubItems.Add(contato.nome);
                item.SubItems.Add(contato.telefone);
                item.SubItems.Add(contato.email);
                item.SubItems.Add(contato.cargo);
                item.SubItems.Add(contato.empresa);
                item.Tag = contato;
                listContatos.Items.Add(item);
            }
        }

        public Contato? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listContatos.SelectedItems[0];
            return listContatos.SelectedItems.Count > 0 ? (Contato)itemSelecionado.Tag : null;
        }
    }
}
