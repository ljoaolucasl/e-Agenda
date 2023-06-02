namespace e_Agenda.Dominio.ModuloTarefa
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
