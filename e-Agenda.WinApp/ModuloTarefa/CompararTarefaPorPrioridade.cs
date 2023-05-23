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
        public int Compare(object? x, object? y)
        {
            ListViewItem mX = (ListViewItem)x;

            ListViewItem mY = (ListViewItem)y;

            int pX = ObterPrioridade(mX.SubItems[2].Text);
            int pY = ObterPrioridade(mY.SubItems[2].Text);

            int resultado = pX.CompareTo(pY);

            return resultado;
        }

        private int ObterPrioridade(string prioridade)
        {
            switch (prioridade.ToLower())
            {
                case "baixa": return 1;
                case "média": return 2;
                case "alta": return 3;
                case "urgente": return 4;
                default: return 0;
            }
        }
    }
}
