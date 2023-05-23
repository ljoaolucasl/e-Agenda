using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public FiltroTarefa FiltroSelecionado
        {
            get
            {
                if (radioVisualizarTodos.Checked)
                    return FiltroTarefa.Todos;
                else if (radioVisualizarPendentes.Checked)
                    return FiltroTarefa.Pendentes;
                else
                    return FiltroTarefa.Concluidas;
            }
        }
    }
}
