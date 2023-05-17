using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa _tarefa;

        public Tarefa? Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                cbPrioridade.Text = value.prioridade;
            }
            get
            {
                return _tarefa;
            }
        }

        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _tarefa = new Tarefa(txtTitulo.Text, cbPrioridade.Text);

            if (_tarefa.id == 0)
                _tarefa.id = int.Parse(txtId.Text);
        }
    }
}
