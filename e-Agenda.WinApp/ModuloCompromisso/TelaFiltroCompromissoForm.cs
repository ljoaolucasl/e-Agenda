using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissoForm : Form
    {
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public FiltroCompromisso FiltroSelecionado
        {
            get
            {
                if (radioVisualizarTodos.Checked)
                    return FiltroCompromisso.Todos;
                else if (radioVisualizarPassados.Checked)
                    return FiltroCompromisso.Passados;
                else
                    return FiltroCompromisso.Futuros;
            }
        }

        public DateTime DataInicial { get { return dtDataInicial.Value; } }

        public DateTime DataFinal { get { return dtDataFinal.Value; } }

        private void radioVisualizarFuturos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVisualizarFuturos.Checked)
                gbDatas.Enabled = true;
            else
                gbDatas.Enabled = false;
        }
    }
}