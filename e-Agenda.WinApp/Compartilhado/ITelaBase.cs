using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public interface ITelaBase<TEntidade> where TEntidade : Entidade
    {
        TextBox TtxtId { get; }

        TEntidade? Entidade { get; set; }

        DialogResult ShowDialog();
    }
}
