using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl, IListagemBase<Tarefa>
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }

        public ListView ListView { get { return listTarefas; } }

        public void AtualizarLista(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                ListViewItem item = new ListViewItem(tarefa.id.ToString());
                item.SubItems.Add(tarefa.titulo);
                item.SubItems.Add(tarefa.prioridade);
                item.SubItems.Add(tarefa.dataCriacao);
                item.SubItems.Add(tarefa.dataConclusao);
                item.SubItems.Add(tarefa.percentual);
                item.Tag = tarefa;
                listTarefas.Items.Add(item);
            }
        }

        public Tarefa? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listTarefas.SelectedItems[0];
            return listTarefas.SelectedItems.Count > 0 ? (Tarefa)itemSelecionado.Tag : null;
        }
    }
}
