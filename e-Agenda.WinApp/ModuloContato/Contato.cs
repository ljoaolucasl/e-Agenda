using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : Entidade
    {
        public string Nome { get; set; }

        public string nome;
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            Nome = nome;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
            this.empresa = empresa;
        }

        public Contato()
        {

        }
    }
}
