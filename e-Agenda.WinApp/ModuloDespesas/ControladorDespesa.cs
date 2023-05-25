using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase<Despesa, RepositorioDespesa, ListagemDespesaControl, TelaDespesaForm, RepositorioCategoria>
    {
        private RepositorioDespesa _repositorioDespesa;
        private RepositorioCategoria _repositorioCategoria;
        private ListagemDespesaControl _listagemDespesa;

        public ControladorDespesa(RepositorioDespesa _repositorio, ListagemDespesaControl _listagem, RepositorioCategoria _repositorio2) : base(_repositorio, _listagem, _repositorio2)
        {
            this._repositorioDespesa = _repositorio;
            this._repositorioCategoria = _repositorio2;
            this._listagemDespesa = _listagem;

            this.onCarregarArquivosSegundoRepositorio += CarregarListaCategorias;
        }

        private void CarregarListaCategorias(TelaDespesaForm telaDespesa)
        {
            telaDespesa.checkListCategorias.Items.AddRange(_repositorioCategoria.ObterListaRegistros().ToArray());
        }

        public override ListagemDespesaControl ObterListagem()
        {
            return _listagem;
        }
    }
}
