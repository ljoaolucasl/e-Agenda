namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public FiltroTarefa FiltroSelecionado
        {
            get
            {
                if (radioVisualizarTodos.Checked)
                    return FiltroTarefa.Todos;
                else if (radioVisualizarPendentes.Checked)
                    return FiltroTarefa.Pendentes;
                else
                    return FiltroTarefa.Concluidas;
            }
        }
    }
}
