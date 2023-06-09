﻿using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaItemForm : Form
    {
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private List<ItemTarefa> _itemTarefa = new();

        public List<ItemTarefa> Entidade
        {
            set
            {
                if (value != null)
                    foreach (ItemTarefa item in value)
                    {
                        listItens.Items.Add(item.nome);
                    }
            }
            get
            {
                return _itemTarefa;
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            ItemTarefa item = new ItemTarefa(txtItem.Text);

            listItens.Items.Add(item.nome);

            _itemTarefa.Add(item);

            txtItem.ResetText();

            txtItem.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
