using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase<Contato, RepositorioContato, ListagemContatoControl, TelaContatoForm>
    {
        private RepositorioContato _repositorioContato;
        private ListagemContatoControl _listagemContato;

        public ControladorContato(RepositorioContato _repositorio, ListagemContatoControl _listagem) : base(_repositorio, _listagem)
        {
            this._repositorioContato = _repositorio;
            this._listagemContato = _listagem;
        }

        public override string ToolTipAdicionar { get { return "Adicionar novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato existente"; } }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        public override ListagemContatoControl ObterListagem()
        {
            return _listagem;
        }
    }
}
