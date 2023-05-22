using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
