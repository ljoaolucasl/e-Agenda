using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloDespesas
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
