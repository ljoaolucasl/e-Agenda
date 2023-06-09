﻿using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Dominio.ModuloCompromisso
{
    [Serializable]
    public class Compromisso : Entidade<Compromisso>
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
