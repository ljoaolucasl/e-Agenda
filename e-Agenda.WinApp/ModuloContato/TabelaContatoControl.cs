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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl, ITabelaBase<Contato>
    {
        public TabelaContatoControl()
        {
            InitializeComponent();

            gridContato.ConfigurarTabelaGrid(new string[] { "Número", "Nome", "Telefone", "Email", "Cargo", "Empresa" });
        }

        public DataGridView DataGridView { get { return gridContato; } }

        public void AtualizarLista(List<Contato> contatos)
        {
            gridContato.Rows.Clear();

            foreach (Contato item in contatos)
            {
                DataGridViewRow row = new();

                row.CreateCells(gridContato, item.id, item.Nome, item.telefone, item.email, item.cargo, item.empresa);

                row.Cells[0].Tag = item;

                gridContato.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {contatos.Count} Contatos");
        }

        public Contato? ObterTarefaSelecionada()
        {
            return (Contato)gridContato.SelectedRows[0].Cells[0].Tag;
        }
    }
}
