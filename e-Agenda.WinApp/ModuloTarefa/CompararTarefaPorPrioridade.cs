using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class CompararTarefaPorPrioridade : IComparer
    {
        private static Dictionary<string, int> prioridades = new Dictionary<string, int>()
        {
            { "Baixa", 0 },
            { "Média", 1 },
            { "Alta", 2 },
            { "Urgente", 3 }
        };

        public int Compare(object x, object y)
        {
            DataGridViewRow rowX = (DataGridViewRow)x;
            DataGridViewRow rowY = (DataGridViewRow)y;

            string prioridadeX = rowX.Cells["prioridade"].Value.ToString();
            string prioridadeY = rowY.Cells["prioridade"].Value.ToString();

            int indicePrioridadeX = prioridades[prioridadeX];
            int indicePrioridadeY = prioridades[prioridadeY];

            return indicePrioridadeX.CompareTo(indicePrioridadeY);
        }
    }
}
