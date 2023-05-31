using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa.Item;

namespace e_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItemTarefa(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            tarefaSelecionada.itens.AddRange(itens);

            RepositorioGlobal.GravarRegistrosEmArquivoBIN();
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

            RepositorioGlobal.GravarRegistrosEmArquivoBIN();
        }

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
