using e_Agenda.WinApp.Compartilhado;
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
    public partial class TabelaTarefaControl : UserControl, ITabelaBase<Tarefa>
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            gridTarefa.ConfigurarTabelaGrid(new string[] { "Número", "Título", "Prioridade", "Data de Criação", "Data de Conclusão", "Concluído (%)" });

            gridTarefa.Columns[2].Name = "prioridade";
        }

        private bool ordenacao = false;

        public DataGridView DataGridView => gridTarefa;

        public void AtualizarLista(List<Tarefa> tarefas)
        {
            gridTarefa.Rows.Clear();

            foreach (Tarefa item in tarefas)
            {
                DataGridViewRow row = new();

                row.CreateCells(gridTarefa, item.id, item.titulo, item.prioridade, item.dataCriacao, item.dataConclusao, item.percentual);

                row.Cells[0].Tag = item;

                gridTarefa.Rows.Add(row);
            }

            gridTarefa.Sort(new CompararTarefaPorPrioridade());

            TelaPrincipalForm.AtualizarStatus($"Visualizando {tarefas.Count} Tarefas");
        }

        public Tarefa? ObterTarefaSelecionada()
        {
            return (Tarefa)gridTarefa.SelectedRows[0].Cells[0].Tag;
        }

        private void gridTarefa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridTarefa.Columns[e.ColumnIndex].Name == "prioridade")
            {
                if (ordenacao)
                {
                    gridTarefa.Sort(new CompararTarefaPorPrioridade());
                    gridTarefa.Columns["prioridade"].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                }
                else
                {
                    gridTarefa.Sort(new CompararTarefaPorPrioridade());
                    gridTarefa.Columns["prioridade"].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                }

                ordenacao = !ordenacao;
            }
        }
    }
}
