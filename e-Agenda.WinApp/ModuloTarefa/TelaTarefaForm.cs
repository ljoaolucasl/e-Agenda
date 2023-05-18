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

        private void Validacoes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Tarefa tarefa = new();

            int contatorErros = 0;

            if (tarefa.ValidarCampoVazio(txtTitulo, avisoErro))
                contatorErros++;

            if (tarefa.ValidarCampoVazio(cbPrioridade, avisoErro))
                contatorErros++;

            if (contatorErros == 2)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            contatorErros = 0;
        }
    }
}
