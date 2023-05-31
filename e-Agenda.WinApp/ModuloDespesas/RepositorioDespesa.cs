using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloDespesas
{
    [Serializable]
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Despesas.Count > 0)
                id = dataContext.Despesas.Max(x => x.id) + 1;
        }

        protected override List<Despesa> ListaRegistros => dataContext.Despesas;
    }
}
