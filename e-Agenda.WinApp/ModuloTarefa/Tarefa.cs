using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : Entidade
    {
        public string titulo;
        public string prioridade;

        public Tarefa(string titulo, string prioridade)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
        }
    }
}
