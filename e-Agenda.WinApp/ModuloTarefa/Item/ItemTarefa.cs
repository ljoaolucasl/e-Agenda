namespace e_Agenda.WinApp.ModuloTarefa.Item
{
    public class ItemTarefa
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
