using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : Entidade
    {
        public string assunto;
        public string data;
        public string inicio;
        public string final;
        public Contato contato;
        public string localizacao;
        public bool remoto;

        public Compromisso(string assunto, string data, string inicio, string termino, Contato contato, string localizacao, bool remoto)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = inicio;
            this.final = termino;
            this.contato = contato;
            this.localizacao = localizacao;
            this.remoto = remoto;
        }

        public Compromisso()
        {
            
        }
    }
}
