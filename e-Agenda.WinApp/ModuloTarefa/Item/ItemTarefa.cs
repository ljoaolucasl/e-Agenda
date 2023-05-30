using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa.Item
{
    [Serializable]
    public class ItemTarefa : Entidade<ItemTarefa>
    {
        public string Nome { get; set; }

        public string nome;

        public bool check = false;

        public ItemTarefa(string nome)
        {
            Nome = nome;
            this.nome = nome;
        }

        public ItemTarefa()
        {

        }
    }
}
