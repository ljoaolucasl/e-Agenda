namespace e_Agenda.WinApp.Compartilhado
{
    public interface IListagemBase<TEntidade> where TEntidade : Entidade
    {
        public ListView ListView { get; }

        public void AtualizarLista(List<TEntidade> contatos);

        public TEntidade ObterContatoSelecionado();
    }
}
