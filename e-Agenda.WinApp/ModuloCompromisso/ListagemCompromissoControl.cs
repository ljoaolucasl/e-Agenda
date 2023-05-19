using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl, IListagemBase<Compromisso>
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Compromisso> compromissos)
        {
            listCompromissos.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                ListViewItem item = new ListViewItem(compromisso.id.ToString());
                item.SubItems.Add(compromisso.assunto);
                item.SubItems.Add(compromisso.data);
                item.SubItems.Add(compromisso.inicio);
                item.SubItems.Add(compromisso.final);
                item.SubItems.Add(compromisso.contato == null ? "" : compromisso.contato.nome);
                item.Tag = compromisso;
                listCompromissos.Items.Add(item);
            }
        }

        public Compromisso? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listCompromissos.SelectedItems[0];
            return listCompromissos.SelectedItems.Count > 0 ? (Compromisso)itemSelecionado.Tag : null;
        }
    }
}
