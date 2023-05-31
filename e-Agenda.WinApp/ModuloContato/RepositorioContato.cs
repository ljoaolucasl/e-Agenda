using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloContato
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
