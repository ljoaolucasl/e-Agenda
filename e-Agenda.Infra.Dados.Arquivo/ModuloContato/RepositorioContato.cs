using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloContato
{
    [Serializable]
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Contatos.Count > 0)
                id = dataContext.Contatos.Max(x => x.id) + 1;
        }

        protected override List<Contato> ListaRegistros => dataContext.Contatos;
    }
}
