using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TabelaCategoriaControl : UserControl, ITabelaBase<Categoria>
    {
        public TabelaCategoriaControl()
        {
            InitializeComponent();

            gridCategoria.ConfigurarTabelaGrid("Número", "Titulo");
        }

        public DataGridView DataGridView => gridCategoria;

        public void AtualizarLista(List<Categoria> categorias)
        {
            gridCategoria.Rows.Clear();

            foreach (Categoria item in categorias)
            {
                DataGridViewRow row = new();

                List<object> lista = new();

                row.CreateCells(gridCategoria, item.id, item.titulo);

                row.Cells[0].Tag = item;

                gridCategoria.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {categorias.Count} Categorias");
        }

        public Categoria? ObterTarefaSelecionada()
        {
            return (Categoria)gridCategoria.SelectedRows[0].Cells[0].Tag;
        }
    }
}
