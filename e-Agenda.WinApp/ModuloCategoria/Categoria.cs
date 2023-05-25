using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class Categoria : Entidade
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
