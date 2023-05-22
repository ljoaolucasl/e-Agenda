using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItemTarefa(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            tarefaSelecionada.itens.AddRange(itens);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, int qtdItensCheck)
        {
            double resultado = Math.Round(((double)qtdItensCheck / tarefaSelecionada.itens.Count) * 100, 0);

            tarefaSelecionada.percentual = resultado.ToString() + "%";

            if (tarefaSelecionada.percentual == "100%")
            {
                tarefaSelecionada.dataConclusao = DateTime.Now.ToString("d");
            }
            else
                tarefaSelecionada.dataConclusao = "";
        }

        public RepositorioTarefa()
        {
            Tarefa tarefa1 = new Tarefa("Pintar a Casa inteira", "Média", "22/03/2023", "", "0%");
            Adicionar(tarefa1);

            Tarefa tarefa2 = new Tarefa("Organizar Palestra Tech", "Baixa", "22/04/2023", "", "0%");
            Adicionar(tarefa2);

            Tarefa tarefa3 = new Tarefa("Organizar Prova para a Turma", "Média", "10/05/2023", "", "0%");
            Adicionar(tarefa3);

            Tarefa tarefa4 = new Tarefa("Finalizar Livro", "Alta", "16/05/2023", "", "0%");
            Adicionar(tarefa4);
        }
    }
}
