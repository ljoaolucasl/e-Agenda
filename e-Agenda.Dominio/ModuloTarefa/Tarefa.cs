namespace e_Agenda.Dominio.ModuloTarefa
{
    [Serializable]
    public class Tarefa : Entidade<Tarefa>
    {
        public string titulo;
        public string prioridade;
        public string dataCriacao;
        public string dataConclusao;
        public string percentual;
        public List<ItemTarefa> itens = new();

        public Tarefa(string titulo, string prioridade, string dataCriacao, string dataConclusao, string percentual)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.dataConclusao = dataConclusao;
            this.percentual = percentual;
        }

        public Tarefa()
        {
            
        }
    }
}
