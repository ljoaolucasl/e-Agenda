﻿using e_Agenda.WinApp.Compartilhado;
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

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl, IListagemBase<Tarefa>
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                ListViewItem item = new ListViewItem(tarefa.id.ToString());
                item.SubItems.Add(tarefa.titulo);
                item.SubItems.Add(tarefa.prioridade);
                item.Tag = tarefa;
                listTarefas.Items.Add(item);
            }
        }

        public Tarefa? ObterContatoSelecionado()
        {
            ListViewItem itemSelecionado = listTarefas.SelectedItems[0];
            return listTarefas.SelectedItems.Count > 0 ? (Tarefa)itemSelecionado.Tag : null;
        }
    }
}