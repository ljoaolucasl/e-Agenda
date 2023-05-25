using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl, IListagemBase<Contato>
    {
        public ListagemContatoControl()
        {
            InitializeComponent();
        }

        public ListView ListView { get { return listContatos; } }

        public void AtualizarLista(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                ListViewItem item = new ListViewItem(contato.id.ToString());
                item.SubItems.Add(contato.Nome);
                item.SubItems.Add(contato.telefone);
                item.SubItems.Add(contato.email);
                item.SubItems.Add(contato.cargo);
                item.SubItems.Add(contato.empresa);
                item.Tag = contato;
                listContatos.Items.Add(item);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {contatos.Count} Contatos");
        }

        public Contato? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listContatos.SelectedItems[0];
            return listContatos.SelectedItems.Count > 0 ? (Contato)itemSelecionado.Tag : null;
        }
    }
}
