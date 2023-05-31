using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloTarefa;
using System.Runtime.Serialization.Formatters.Binary;

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

        private RepositorioGlobal _repositorioGlobal;

        private TabelaContatoControl _tabelaContato = new();
        private TabelaTarefaControl _tabelaTarefa = new();
        private TabelaCompromissoControl _tabelaCompromisso = new();
        private TabelaDespesaControl _tabelaDespesa = new();
        private TabelaCategoriaControl _tabelaCategoria = new();


        private static TelaPrincipalForm _telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            _telaPrincipal = this;

            List<object> dados = new()
            {
                _repositorioContato,
                _repositorioTarefa,
                _repositorioCompromisso,
                _repositorioDespesa,
                _repositorioCategoria
            };

            _repositorioGlobal = new RepositorioGlobal(dados);

            if (File.Exists(RepositorioGlobal.CAMINHO_ARQUIVO))
            {
                RepositorioGlobal.CarregarRegistrosDoArquivoBIN();
                _repositorioContato = (RepositorioContato)RepositorioGlobal.Dados[0];
                _repositorioTarefa = (RepositorioTarefa)RepositorioGlobal.Dados[1];
                _repositorioCompromisso = (RepositorioCompromisso)RepositorioGlobal.Dados[2];
                _repositorioDespesa = (RepositorioDespesa)RepositorioGlobal.Dados[3];
                _repositorioCategoria = (RepositorioCategoria)RepositorioGlobal.Dados[4];
            }
        }

        public static void AtualizarStatus(string status)
        {
            _telaPrincipal.lbStatus.Text = status;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorContato(_repositorioContato, _tabelaContato);

            ConfigurarTelaPrincipal();
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorTarefa(_repositorioTarefa, _tabelaTarefa);

            ConfigurarTelaPrincipal();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorCompromisso(_repositorioCompromisso, _tabelaCompromisso, _repositorioContato);

            ConfigurarTelaPrincipal();
        }

        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorDespesa(_repositorioDespesa, _tabelaDespesa, _repositorioCategoria);

            ConfigurarTelaPrincipal();
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorCategoria(_repositorioCategoria, _tabelaCategoria, _repositorioDespesa);

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

            ((DataGridView)(_listagem.Controls[0])).SelectionChanged += HabilitaEDesabilitaBotoes;
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
        }

        private void ConfigurarBotaoVisualizarDepesas()
        {
            if (_controladorBase is ControladorCategoria && ((DataGridView)_listagem.Controls[0]).SelectedRows.Count > 0)
                btnVisualizarDespesas.Enabled = true;
            else
                btnVisualizarDespesas.Enabled = false;
        }

        private void ConfigurarBotoesItens()
        {
            if (_controladorBase is ControladorTarefa && ((DataGridView)_listagem.Controls[0]).SelectedRows.Count > 0)
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
            if (((DataGridView)_listagem.Controls[0]).SelectedRows.Count > 0)
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

        public void PopularListas()
        {
            Categoria categoria1 = new Categoria("Confraternização");
            _repositorioCategoria.Adicionar(categoria1);

            Categoria categoria2 = new Categoria("Mercado");
            _repositorioCategoria.Adicionar(categoria2);

            Categoria categoria3 = new Categoria("Farmácia");
            _repositorioCategoria.Adicionar(categoria3);

            Categoria categoria4 = new Categoria("Combustível");
            _repositorioCategoria.Adicionar(categoria4);

            Compromisso compromisso1 = new Compromisso("Reunião da Academia", "24/06/2023", "19:00", "21:00", null, "Uniplac", false);
            _repositorioCompromisso.Adicionar(compromisso1);

            Compromisso compromisso2 = new Compromisso("Aniversário Surpresa", "24/05/2023", "20:00", "23:00", null, "Casa do Marcos", false);
            _repositorioCompromisso.Adicionar(compromisso2);

            Compromisso compromisso3 = new Compromisso("Reunião do Trabalho", "20/05/2023", "15:00", "16:30", null, "Meet", true);
            _repositorioCompromisso.Adicionar(compromisso3);

            Compromisso compromisso4 = new Compromisso("Casamento", "24/09/2023", "10:00", "21:00", null, "Retiro Bom Ar", false);
            _repositorioCompromisso.Adicionar(compromisso4);

            Contato contato1 = new Contato("José Pedro", "(49)99954-8712", "josepedro1@gmail.com", "Padeiro", "Panificadora Silva");
            _repositorioContato.Adicionar(contato1);

            Contato contato2 = new Contato("Maria Pereira", "(49)99967-3452", "mpereiraa@gmail.com", "Dentista", "Odonto Pass");
            _repositorioContato.Adicionar(contato2);

            Contato contato3 = new Contato("Lucas Mota", "(49)99923-2266", "lucmota@gmail.com", "Analista Chefe", "CTech");
            _repositorioContato.Adicionar(contato3);

            Contato contato4 = new Contato("Carla Moraes", "(49)99933-5621", "carla2002@gmail.com", "Especialista em Moda", "Style Brasil");
            _repositorioContato.Adicionar(contato4);

            Despesa despesa1 = new Despesa("Jantar dos Amigos", "300", "22/04/2023", "Dinheiro");
            _repositorioDespesa.Adicionar(despesa1);

            Despesa despesa2 = new Despesa("Evento Tech", "1200", "14/03/2023", "Credito");
            _repositorioDespesa.Adicionar(despesa2);

            Despesa despesa3 = new Despesa("Viagem Exterior", "2400", "10/02/2023", "Debito");
            _repositorioDespesa.Adicionar(despesa3);

            Despesa despesa4 = new Despesa("Churrasco Empresa", "50", "20/05/2023", "Pix");
            _repositorioDespesa.Adicionar(despesa4);

            Tarefa tarefa1 = new Tarefa("Pintar a Casa inteira", "Média", "22/03/2023", "", "0%");
            _repositorioTarefa.Adicionar(tarefa1);

            Tarefa tarefa2 = new Tarefa("Organizar Palestra Tech", "Baixa", "22/04/2023", "", "0%");
            _repositorioTarefa.Adicionar(tarefa2);

            Tarefa tarefa3 = new Tarefa("Organizar Prova para a Turma", "Média", "10/05/2023", "", "0%");
            _repositorioTarefa.Adicionar(tarefa3);

            Tarefa tarefa4 = new Tarefa("Finalizar Livro", "Alta", "16/05/2023", "", "0%");
            _repositorioTarefa.Adicionar(tarefa4);
        }
    }
}