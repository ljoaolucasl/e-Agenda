using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : System.Windows.Forms.Form
    {
        private ControladorBase _controladorBase;
        private RepositorioContato _repositorioContato = new();
        private RepositorioTarefa _repositorioTarefa = new();
        private RepositorioCompromisso _repositorioCompromisso = new();
        private UserControl _listagem;

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorContato(_repositorioContato);

            ConfigurarTelaPrincipal();
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorTarefa(_repositorioTarefa);

            ConfigurarTelaPrincipal();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorCompromisso(_repositorioCompromisso, _repositorioContato);

            ConfigurarTelaPrincipal();
        }

        private void ConfigurarTelaPrincipal()
        {
            if (_controladorBase is ControladorCompromisso)
                btnFiltrar.Enabled = true;
            else
                btnFiltrar.Enabled = false;

            ConfigurarListagem();

            ConfigurarToolTipsAndButtons();

            AbrirListagem();
        }

        private void ConfigurarListagem()
        {
            _listagem = _controladorBase.ObterListagem();

            _listagem.Dock = DockStyle.Fill;

            ((ListView)(_listagem.Controls[0])).SelectedIndexChanged += HabilitaEDesabilitaBotoes;
        }

        private void ConfigurarToolTipsAndButtons()
        {
            btnAdd.ToolTipText = _controladorBase.ToolTipAdicionar;
            btnEditar.ToolTipText = _controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = _controladorBase.ToolTipExcluir;
            btnAdd.Enabled = true;
        }

        private void AbrirListagem()
        {
            lblTipoCadastro.Text = _controladorBase.ObterTipoCadastro();
            plPrincipal.Controls.Clear();
            plPrincipal.Controls.Add(_listagem);
            _controladorBase.CarregarRegistros();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controladorBase.Adicionar();
            ResetarBotoes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controladorBase.Editar();
            ResetarBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controladorBase.Excluir();
            ResetarBotoes();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            _controladorBase.Filtrar();
        }

        private void HabilitaEDesabilitaBotoes(object sender, EventArgs e)
        {
            if (((ListView)_listagem.Controls[0]).SelectedItems.Count > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                ResetarBotoes();
            }
        }

        private void ResetarBotoes()
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}