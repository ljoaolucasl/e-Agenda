using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : Entidade
    {
        public string assunto;
        public string data;
        public string inicio;
        public string termino;
        public string contato;

        public Compromisso(string assunto, string data, string comeco, string termino, string contato)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = comeco;
            this.termino = termino;
            this.contato = contato;
        }
    }
}
