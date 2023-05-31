namespace e_Agenda.WinApp.Compartilhado
{
    [Serializable]
    public abstract class RepositorioBase<TEntidade> where TEntidade : Entidade<TEntidade>
    {
        protected DataContext dataContext;

        protected int id = 1001;

        public int Id { get { return id; } }

        public RepositorioBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        protected abstract List<TEntidade> ListaRegistros { get; }

        public void Adicionar(TEntidade registro)
        {
            registro.id = id; id++;
            ListaRegistros.Add(registro);
            dataContext.GravarRegistrosEmArquivoBIN();
        }

        public void Editar(TEntidade novoRegistro)
        {
            TEntidade registroAntigo = SelecionarId(novoRegistro.id);

            foreach (var atributo in registroAntigo.GetType().GetFields())
            {
                if (atributo.Name != "id")
                    atributo.SetValue(registroAntigo, atributo.GetValue(novoRegistro));
            }

            foreach (var property in registroAntigo.GetType().GetProperties())
            {
                if (property.Name != "Id")
                    property.SetValue(registroAntigo, property.GetValue(novoRegistro));
            }

            dataContext.GravarRegistrosEmArquivoBIN();
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            ListaRegistros.Remove(registroSelecionado);

            dataContext.GravarRegistrosEmArquivoBIN();
        }

        public TEntidade SelecionarId(int idEscolhido)
        {
            return ListaRegistros.Find(e => e.id == idEscolhido);
        }

        public List<TEntidade> ObterListaRegistros()
        {
            return ListaRegistros;
        }
    }
}
