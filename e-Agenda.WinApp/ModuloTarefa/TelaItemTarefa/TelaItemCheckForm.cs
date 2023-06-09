﻿using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa.Item
{
    public partial class TelaItemCheckForm : Form
    {
        public TelaItemCheckForm()
        {
            InitializeComponent();
        }

        private List<ItemTarefa> _itemTarefa = new();

        public List<ItemTarefa> Entidade
        {
            set
            {
                if (value != null)
                {
                    foreach (ItemTarefa item in value)
                    {
                        checkListItens.Items.Add(item.nome);

                        if (item.check)
                            checkListItens.SetItemChecked(checkListItens.Items.Count - 1, true);
                    }
                }
            }
            get
            {
                return _itemTarefa;
            }
        }
    }
}
