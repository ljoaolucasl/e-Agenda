using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloCategoria
{
    [Serializable]
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public RepositorioCategoria(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Categorias.Count > 0)
                id = dataContext.Categorias.Max(x => x.id) + 1;
        }

        protected override List<Categoria> ListaRegistros => dataContext.Categorias;
    }
}
