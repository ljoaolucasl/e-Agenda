using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private IControladorBase _controladorBase;
        private UserControl _listagem;
        private RepositorioContato _repositorioContato = new();
        private RepositorioTarefa _repositorioTarefa = new();
        private RepositorioCompromisso _repositorioCompromisso = new();
        private RepositorioDespesa _repositorioDespesa = new();
        private RepositorioCategoria _repositorioCategoria = new();
        private ListagemContatoControl _listagemContato = new();
        private ListagemTarefaControl _listagemTarefa = new();
        private ListagemCompromissoControl _listagemCompromisso = new();
        private ListagemDespesaControl _listagemDespesa = new();
        private ListagemCategoriaControl _listagemCategoria = new();

        private static TelaPrincipalForm _telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            _telaPrincipal = this;
        }

        public static void AtualizarStatus(string status)
        {
            _telaPrincipal.lbStatus.Text = status;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorContato(_repositorioContato, _listagemContato);

            ConfigurarTelaPrincipal();
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorTarefa(_repositorioTarefa, _listagemTarefa);

            ConfigurarTelaPrincipal();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorCompromisso(_repositorioCompromisso, _listagemCompromisso, _repositorioContato);

            ConfigurarTelaPrincipal();
        }

        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorDespesa(_repositorioDespesa, _listagemDespesa, _repositorioCategoria);

            ConfigurarTelaPrincipal();
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorCategoria(_repositorioCategoria, _listagemCategoria, _repositorioDespesa);

            ConfigurarTelaPrincipal();
        }

        private void ConfigurarTelaPrincipal()
        {
            ResetarBotoes();

            ConfigurarBotaoFiltro();

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

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            _controladorBase.AdicionarItens();
            ResetarBotoes();
        }

        private void btnAtualizarItens_Click(object sender, EventArgs e)
        {
            _controladorBase.AtualizarItensCheck();
            ResetarBotoes();
        }

        private void btnVisualizarDespesas_Click(object sender, EventArgs e)
        {
            _controladorBase.VisualizarDespesasPorCategoria();
            ResetarBotoes();
        }

        private void HabilitaEDesabilitaBotoes(object sender, EventArgs e)
        {
            ConfigurarBotoesCrud();

            ConfigurarBotaoFiltro();

            ConfigurarBotoesItens();

            ConfigurarBotaoVisualizarDepesas();

            AtualizarStatus($"{((ListView)(_listagem.Controls[0])).SelectedItems.Count} Iten(s) Selecionado(s)");
        }

        private void ConfigurarBotaoVisualizarDepesas()
        {
            if (_controladorBase is ControladorCategoria && ((ListView)_listagem.Controls[0]).SelectedItems.Count > 0)
                btnVisualizarDespesas.Enabled = true;
            else
                btnVisualizarDespesas.Enabled = false;
        }

        private void ConfigurarBotoesItens()
        {
            if (_controladorBase is ControladorTarefa && ((ListView)_listagem.Controls[0]).SelectedItems.Count > 0)
            {
                btnAdicionarItem.Enabled = true;
                btnAtualizarItens.Enabled = true;
            }
            else
            {
                btnAdicionarItem.Enabled = false;
                btnAtualizarItens.Enabled = false;
            }
        }

        private void ConfigurarBotaoFiltro()
        {
            if (_controladorBase is ControladorCompromisso || _controladorBase is ControladorTarefa)
                btnFiltrar.Enabled = true;
            else
                btnFiltrar.Enabled = false;
        }

        private void ConfigurarBotoesCrud()
        {
            if (((ListView)_listagem.Controls[0]).SelectedItems.Count > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void ResetarBotoes()
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAdicionarItem.Enabled = false;
            btnAtualizarItens.Enabled = false;
            btnFiltrar.Enabled = false;
            btnVisualizarDespesas.Enabled = false;

            ConfigurarBotaoFiltro();
        }  
    }
}