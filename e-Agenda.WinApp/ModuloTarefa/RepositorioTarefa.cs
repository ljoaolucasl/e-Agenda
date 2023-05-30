using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa.Item;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItemTarefa(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            tarefaSelecionada.itens.AddRange(itens);

            GravarRegistrosEmArquivoBIN();
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, int qtdItensCheck)
        {
            double resultado = Math.Round(((double)qtdItensCheck / tarefaSelecionada.itens.Count) * 100, 0);

            if (Double.IsNaN(resultado))
                resultado = 0;
            
            tarefaSelecionada.percentual = resultado.ToString() + "%";

            if (tarefaSelecionada.percentual == "100%")
            {
                tarefaSelecionada.dataConclusao = DateTime.Now.ToString("d");
            }
            else
                tarefaSelecionada.dataConclusao = "";

            GravarRegistrosEmArquivoBIN();
        }

        //public RepositorioTarefa()
        //{
        //    Tarefa tarefa1 = new Tarefa("Pintar a Casa inteira", "Média", "22/03/2023", "", "0%");
        //    Adicionar(tarefa1);

        //    Tarefa tarefa2 = new Tarefa("Organizar Palestra Tech", "Baixa", "22/04/2023", "", "0%");
        //    Adicionar(tarefa2);

        //    Tarefa tarefa3 = new Tarefa("Organizar Prova para a Turma", "Média", "10/05/2023", "", "0%");
        //    Adicionar(tarefa3);

        //    Tarefa tarefa4 = new Tarefa("Finalizar Livro", "Alta", "16/05/2023", "", "0%");
        //    Adicionar(tarefa4);
        //}

        public List<Tarefa> FiltrarTarefasPendentes()
        {
            List<Tarefa> TarefasPendentes = new List<Tarefa>();

            foreach (Tarefa tarefa in ObterListaRegistros().Cast<Tarefa>().Where(tarefa => tarefa.percentual != "100%"))
            {
                TarefasPendentes.Add(tarefa);
            }

            return TarefasPendentes;
        }

        public List<Tarefa> FiltrarTarefasConcluidas()
        {
            List<Tarefa> TarefasConcluidas = new List<Tarefa>();

            foreach (Tarefa tarefa in ObterListaRegistros().Cast<Tarefa>().Where(tarefa => tarefa.percentual == "100%"))
            {
                TarefasConcluidas.Add(tarefa);
            }

            return TarefasConcluidas;
        }
    }
}
