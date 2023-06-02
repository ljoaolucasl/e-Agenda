namespace e_Agenda.Dominio.ModuloCategoria
{
    [Serializable]
    public class Categoria : Entidade<Categoria>
    {
        public string titulo;
        public bool check = false;

        public Categoria(string titulo)
        {
            this.titulo = titulo;
        }

        public Categoria()
        {
            
        }

        public override string? ToString()
        {
            return titulo;
        }
    }
}
