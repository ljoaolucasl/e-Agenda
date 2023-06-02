using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Infra.Dados.Arquivo.ModuloContato;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase<Contato, RepositorioContato, TabelaContatoControl, TelaContatoForm, NenhumRepositorio>
    {
        private RepositorioContato _repositorioContato;
        private TabelaContatoControl _tabelaContato;

        public ControladorContato(RepositorioContato _repositorio, TabelaContatoControl _tabela) : base(_repositorio, _tabela)
        {
            this._repositorioContato = _repositorio;
            this._tabelaContato = _tabela;
        }

        public override TabelaContatoControl ObterListagem()
        {
            return _tabela;
        }
    }
}
