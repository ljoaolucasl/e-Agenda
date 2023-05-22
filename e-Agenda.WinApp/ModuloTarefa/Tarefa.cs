using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa.Item;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : Entidade
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
