using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase<TEntidade, TRepositorio, TListagem, TTela> : IControladorBase
        where TEntidade : Entidade 
        where TRepositorio : RepositorioBase<TEntidade> 
        where TListagem : IListagemBase<TEntidade>, new()
        where TTela : ITelaBase<TEntidade>, new()
    {
        protected TRepositorio _repositorio;
        protected TListagem _listagem;

        protected event Action<TTela> onCarregarComboBox;

        public ControladorBase(TRepositorio _repositorio, TListagem _listagem)
        {
            this._repositorio = _repositorio;
            this._listagem = _listagem;
        }

        public ControladorBase(TRepositorio _repositorio, TListagem _listagem, RepositorioContato _repositorioContato)
        {
            this._repositorio = _repositorio;
            this._listagem = _listagem;
        }

        public abstract string ToolTipAdicionar { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual void Adicionar()
        {
            TTela tela = new TTela();

            if (onCarregarComboBox != null)
                onCarregarComboBox(tela);

            tela.TtxtId.Text = _repositorio.Id.ToString();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TEntidade? entidade = tela.Entidade;

                _repositorio.Adicionar(entidade);

                CarregarRegistros();
            }
        }

        public virtual void Editar()
        {
            TEntidade? entidade = _listagem.ObterContatoSelecionado();

            TTela tela = new TTela();

            if (onCarregarComboBox != null)
                onCarregarComboBox(tela);

            tela.Entidade = entidade;

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorio.Editar(tela.Entidade);

                CarregarRegistros();
            }
        }

        public virtual void Excluir()
        {
            TEntidade? entidade = _listagem.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja mesmo excluir?", "Exclusão de Tarefas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _repositorio.Excluir(entidade);

                CarregarRegistros();
            }
        }

        public virtual void Filtrar() {  }

        public virtual void AdicionarItens() { }

        public virtual void AtualizarItensCheck() { }

        public virtual void CarregarRegistros()
        {
            _listagem.AtualizarLista(_repositorio.ObterListaRegistros());
        }

        public abstract string ObterTipoCadastro();

        public abstract UserControl ObterListagem();
    }
}
