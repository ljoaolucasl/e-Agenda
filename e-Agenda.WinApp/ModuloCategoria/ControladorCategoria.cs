using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloTarefa.Item;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase<Categoria, RepositorioCategoria, ListagemCategoriaControl, TelaCategoriaForm, RepositorioDespesa>
    {
        private RepositorioCategoria _repositorioCategoria;
        private RepositorioDespesa _repositorioDespesa;
        private ListagemCategoriaControl _listagemCategoria;

        public ControladorCategoria(RepositorioCategoria _repositorio, ListagemCategoriaControl _listagem, RepositorioDespesa _repositorio2) : base(_repositorio, _listagem, _repositorio2)
        {
            this._repositorioCategoria = _repositorio;
            this._repositorioDespesa = _repositorio2;
            this._listagemCategoria = _listagem;
        }

        public override ListagemCategoriaControl ObterListagem()
        {
            return _listagem;
        }

        public override void VisualizarDespesasPorCategoria()
        {
            TelaDepesasPorCategoriaForm telaDepesasCategoria = new();

            Categoria categoriaSelecionada = null;

            foreach (ListViewItem categoria in _listagemCategoria.ListView.SelectedItems)
            {
                telaDepesasCategoria.lbCategoria.Text = categoria.SubItems[1].Text;
                categoriaSelecionada = (Categoria)categoria.Tag;
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando Despesas por Categoria");

            telaDepesasCategoria.listDespesas.Items.AddRange(_repositorioDespesa.ObterListaRegistros().Cast<Despesa>().Where(despesa => despesa.categorias.Contains(categoriaSelecionada)).ToArray());

            telaDepesasCategoria.ShowDialog();
        }
    }
}
