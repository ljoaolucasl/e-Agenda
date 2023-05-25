using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase<Despesa, RepositorioDespesa, TabelaDespesaControl, TelaDespesaForm, RepositorioCategoria>
    {
        private RepositorioDespesa _repositorioDespesa;
        private RepositorioCategoria _repositorioCategoria;
        private TabelaDespesaControl _tabelaDespesa;

        public ControladorDespesa(RepositorioDespesa _repositorio, TabelaDespesaControl _tabela, RepositorioCategoria _repositorio2) : base(_repositorio, _tabela, _repositorio2)
        {
            this._repositorioDespesa = _repositorio;
            this._repositorioCategoria = _repositorio2;
            this._tabelaDespesa = _tabela;

            this.onCarregarArquivosSegundoRepositorio += CarregarListaCategorias;
        }

        private void CarregarListaCategorias(TelaDespesaForm telaDespesa)
        {
            telaDespesa.checkListCategorias.Items.AddRange(_repositorioCategoria.ObterListaRegistros().ToArray());
        }

        public override TabelaDespesaControl ObterListagem()
        {
            return _tabela;
        }
    }
}
