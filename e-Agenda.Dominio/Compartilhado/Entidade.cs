using System.Drawing;

namespace e_Agenda.Dominio.Compartilhado
{
    [Serializable]
    public abstract class Entidade<TEntidade>
    {
        public int id;
    }
}