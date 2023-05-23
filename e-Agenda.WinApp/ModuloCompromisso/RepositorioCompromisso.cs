using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Tarefa>
    {
        public RepositorioCompromisso()
        {
            Tarefa compromisso1 = new Tarefa("Reunião da Academia", "24/06/2023", "19:00", "21:00", null, "Uniplac", false);
            Adicionar(compromisso1);

            Tarefa compromisso2 = new Tarefa("Aniversário Surpresa", "24/05/2023", "20:00", "23:00", null, "Casa do Marcos", false);
            Adicionar(compromisso2);

            Tarefa compromisso3 = new Tarefa("Reunião do Trabalho", "20/05/2023", "15:00", "16:30", null, "Meet", true);
            Adicionar(compromisso3);

            Tarefa compromisso4 = new Tarefa("Casamento", "24/09/2023", "10:00", "21:00", null, "Retiro Bom Ar", false);
            Adicionar(compromisso4);
        }

        public List<Tarefa> FiltrarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Tarefa> compromissosFuturos = new List<Tarefa>();

            foreach (Tarefa compromisso in ObterListaRegistros().Cast<Tarefa>().Where(compromisso => Convert.ToDateTime(compromisso.data) >= dataInicial && Convert.ToDateTime(compromisso.data) <= dataFinal))
            {
                compromissosFuturos.Add(compromisso);
            }

            return compromissosFuturos;
        }

        public List<Tarefa> FiltrarCompromissosPassados(DateTime dataDeHoje)
        {
            List<Tarefa> compromissosPassados = new List<Tarefa>();

            foreach (Tarefa compromisso in ObterListaRegistros().Cast<Tarefa>().Where(compromisso => Convert.ToDateTime(compromisso.data) < dataDeHoje))
            {
                compromissosPassados.Add(compromisso);
            }

            return compromissosPassados;
        }
    }
}
