using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso()
        {
            Compromisso compromisso1 = new Compromisso("Reunião da Academia", "24/06/2023", "19:00", "21:00", null, "Uniplac", false);
            Adicionar(compromisso1);

            Compromisso compromisso2 = new Compromisso("Aniversário Surpresa", "24/05/2023", "20:00", "23:00", null, "Casa do Marcos", false);
            Adicionar(compromisso2);

            Compromisso compromisso3 = new Compromisso("Reunião do Trabalho", "20/05/2023", "15:00", "16:30", null, "Meet", true);
            Adicionar(compromisso3);

            Compromisso compromisso4 = new Compromisso("Casamento", "24/09/2023", "10:00", "21:00", null, "Retiro Bom Ar", false);
            Adicionar(compromisso4);
        }

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
