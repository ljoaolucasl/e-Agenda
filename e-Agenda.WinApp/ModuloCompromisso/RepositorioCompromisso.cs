using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    [Serializable]
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> FiltrarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso compromisso in ObterListaRegistros().Cast<Compromisso>().Where(compromisso => Convert.ToDateTime(compromisso.data) >= dataInicial && Convert.ToDateTime(compromisso.data) <= dataFinal))
            {
                compromissosFuturos.Add(compromisso);
            }

            return compromissosFuturos;
        }

        public List<Compromisso> FiltrarCompromissosPassados(DateTime dataDeHoje)
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso compromisso in ObterListaRegistros().Cast<Compromisso>().Where(compromisso => Convert.ToDateTime(compromisso.data) < dataDeHoje))
            {
                compromissosPassados.Add(compromisso);
            }

            return compromissosPassados;
        }
    }
}
