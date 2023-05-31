using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    [Serializable]
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Compromissos.Count > 0)
                id = dataContext.Compromissos.Max(x => x.id) + 1;
        }

        protected override List<Compromisso> ListaRegistros => dataContext.Compromissos;

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
