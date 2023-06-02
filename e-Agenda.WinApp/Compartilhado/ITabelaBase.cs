using e_Agenda.Dominio.Compartilhado;

namespace e_Agenda.WinApp.Compartilhado
{
    public interface ITabelaBase<TEntidade> where TEntidade : Entidade<TEntidade>
    {
        public DataGridView DataGridView { get; }

        public void AtualizarLista(List<TEntidade> contatos);

        public TEntidade ObterTarefaSelecionada();
    }
}
