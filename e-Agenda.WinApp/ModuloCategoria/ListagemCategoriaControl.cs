using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDespesas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class ListagemCategoriaControl : UserControl, IListagemBase<Categoria>
    {
        public ListagemCategoriaControl()
        {
            InitializeComponent();
        }

        public ListView ListView { get { return listCategorias; } }

        public void AtualizarLista(List<Categoria> categorias)
        {
            listCategorias.Items.Clear();

            foreach (Categoria categoria in categorias)
            {
                ListViewItem item = new ListViewItem(categoria.id.ToString());
                item.SubItems.Add(categoria.titulo);
                item.Tag = categoria;
                listCategorias.Items.Add(item);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {categorias.Count} Categorias");
        }

        public Categoria? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listCategorias.SelectedItems[0];
            return listCategorias.SelectedItems.Count > 0 ? (Categoria)itemSelecionado.Tag : null;
        }
    }
}
