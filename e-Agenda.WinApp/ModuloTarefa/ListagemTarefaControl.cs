using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl, ITabelaBase<Tarefa>
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView { get; }

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

            listTarefas.ListViewItemSorter = new CompararTarefaPorPrioridade();
            listTarefas.Sort();

            TelaPrincipalForm.AtualizarStatus($"Visualizando {tarefas.Count} Tarefas");
        }

        public Tarefa? ObterTarefaSelecionada()
        {
            ListViewItem itemSelecionado = listTarefas.SelectedItems[0];
            return listTarefas.SelectedItems.Count > 0 ? (Tarefa)itemSelecionado.Tag : null;
        }
    }
}
