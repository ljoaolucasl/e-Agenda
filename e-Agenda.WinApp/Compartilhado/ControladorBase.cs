using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase<TEntidade, TRepositorio, TListagem, TTela, TRepositorio2> : IControladorBase
        where TEntidade : Entidade 
        where TRepositorio : RepositorioBase<TEntidade> 
        where TListagem : IListagemBase<TEntidade>, new()
        where TTela : ITelaBase<TEntidade>, new()
    {
        protected TRepositorio _repositorio;
        protected TRepositorio2 _repositorio2;
        protected TListagem _listagem;

        protected event Action<TTela> onCarregarArquivosSegundoRepositorio;

        public ControladorBase(TRepositorio _repositorio, TListagem _listagem)
        {
            this._repositorio = _repositorio;
            this._listagem = _listagem;
        }

        public ControladorBase(TRepositorio _repositorio, TListagem _listagem, TRepositorio2 _repositorio2)
        {
            this._repositorio = _repositorio;
            this._listagem = _listagem;
            this._repositorio2 = _repositorio2;
        }

        public virtual string ToolTipAdicionar => $"Adicionar {typeof(TEntidade).Name}";

        public virtual string ToolTipEditar => $"Editar {typeof(TEntidade).Name} existente";

        public virtual string ToolTipExcluir => $"Excluir {typeof(TEntidade).Name} existente";

        public virtual void Adicionar()
        {
            TTela tela = new TTela();

            if (onCarregarArquivosSegundoRepositorio != null)
                onCarregarArquivosSegundoRepositorio(tela);

            tela.TtxtId.Text = _repositorio.Id.ToString();

            TelaPrincipalForm.AtualizarStatus($"Cadastrando {typeof(TEntidade).Name}");

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TEntidade? entidade = tela.Entidade;

                _repositorio.Adicionar(entidade);

            }
                CarregarRegistros();
        }

        public virtual void Editar()
        {
            TEntidade? entidade = _listagem.ObterContatoSelecionado();

            TTela tela = new TTela();

            if (onCarregarArquivosSegundoRepositorio != null)
                onCarregarArquivosSegundoRepositorio(tela);

            tela.Entidade = entidade;

            TelaPrincipalForm.AtualizarStatus($"Editando {typeof(TEntidade).Name}");

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorio.Editar(tela.Entidade);

            }
                CarregarRegistros();
        }

        public virtual void Excluir()
        {
            TEntidade? entidade = _listagem.ObterContatoSelecionado();

            TelaPrincipalForm.AtualizarStatus($"Excluindo {typeof(TEntidade).Name}");

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja mesmo excluir?", $"Exclusão de {typeof(TEntidade).Name}",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _repositorio.Excluir(entidade);

            }
                CarregarRegistros();
        }

        public virtual void Filtrar() {  }

        public virtual void AdicionarItens() { }

        public virtual void AtualizarItensCheck() { }

        public virtual void VisualizarDespesasPorCategoria() { }

        public virtual void CarregarRegistros()
        {
            _listagem.AtualizarLista(_repositorio.ObterListaRegistros());
        }

        public virtual string ObterTipoCadastro()
        {
            return $"Cadastro de {typeof(TEntidade).Name}s";
        }

        public abstract UserControl ObterListagem();
    }
}
