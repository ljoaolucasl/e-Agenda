namespace e_Agenda.WinApp.Compartilhado
{
    public interface ITabelaBase<TEntidade> where TEntidade : Entidade
    {
        public DataGridView DataGridView { get; }

        public void AtualizarLista(List<TEntidade> contatos);

        public TEntidade ObterTarefaSelecionada();
    }
}
