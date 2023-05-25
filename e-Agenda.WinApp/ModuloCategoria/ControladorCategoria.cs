using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloTarefa.Item;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase<Categoria, RepositorioCategoria, TabelaCategoriaControl, TelaCategoriaForm, RepositorioDespesa>
    {
        private RepositorioCategoria _repositorioCategoria;
        private RepositorioDespesa _repositorioDespesa;
        private TabelaCategoriaControl _tabelaCategoria;

        public ControladorCategoria(RepositorioCategoria _repositorio, TabelaCategoriaControl _tabela, RepositorioDespesa _repositorio2) : base(_repositorio, _tabela, _repositorio2)
        {
            this._repositorioCategoria = _repositorio;
            this._repositorioDespesa = _repositorio2;
            this._tabelaCategoria = _tabela;
        }

        public override TabelaCategoriaControl ObterListagem()
        {
            return _tabela;
        }

        public override void VisualizarDespesasPorCategoria()
        {
            TelaDepesasPorCategoriaForm telaDepesasCategoria = new();

            Categoria categoriaSelecionada = null;

            //foreach (ListViewItem categoria in _tabelaCategoria.ListView.SelectedItems)
            //{
            //    telaDepesasCategoria.lbCategoria.Text = categoria.SubItems[1].Text;
            //    categoriaSelecionada = (Categoria)categoria.Tag;
            //}

            categoriaSelecionada = _tabelaCategoria.ObterTarefaSelecionada();

            telaDepesasCategoria.lbCategoria.Text = categoriaSelecionada.titulo;


            TelaPrincipalForm.AtualizarStatus($"Visualizando Despesas por Categoria");

            telaDepesasCategoria.listDespesas.Items.AddRange(_repositorioDespesa.ObterListaRegistros().Cast<Despesa>().Where(despesa => despesa.categorias.Contains(categoriaSelecionada)).ToArray());

            telaDepesasCategoria.ShowDialog();
        }
    }
}
