using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form, ITelaBase<Tarefa>
    {
        private Tarefa _tarefa;

        public TextBox TtxtId { get { return txtId; } }

        public Tarefa? Entidade
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
            _tarefa = new Tarefa(txtTitulo.Text, cbPrioridade.Text, DateTime.Now.Date.ToString("d"), "", "0%");

            if (_tarefa.id == 0)
                _tarefa.id = int.Parse(txtId.Text);
        }

        private void Validacoes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Tarefa tarefa = new();

            int contatorErros = 0;

            if (ValidarCampoVazio(txtTitulo, avisoErro))
                contatorErros++;
            
            if (ValidarCampoVazio(cbPrioridade, avisoErro))
                contatorErros++;

            if (contatorErros == 2)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            contatorErros = 0;
        }

        public bool ValidarCampoVazio(Control control, ErrorProvider avisoErro)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                avisoErro.SetError(control, "Campo Obrigatório");
                control.BackColor = SystemColors.Info;
                return false;
            }
            else
            {
                avisoErro.SetError(control, "");
                control.BackColor = SystemColors.Window;
                return true;
            }
        }
    }
}
