namespace e_Agenda.WinApp.Compartilhado
{
    public interface IListagemBase<TEntidade> where TEntidade : Entidade
    {
        public void AtualizarLista(List<TEntidade> contatos);

        public TEntidade ObterContatoSelecionado();
    }
}
