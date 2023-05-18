﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipAdicionar { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public abstract void Adicionar();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract void Filtrar();

        public abstract void CarregarRegistros();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }
}