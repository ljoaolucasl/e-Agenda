using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase<Tarefa, RepositorioTarefa, ListagemTarefaControl, TelaTarefaForm>
    {
        private RepositorioTarefa _repositorioTarefa;
        private ListagemTarefaControl _listagemTarefa;

        public ControladorTarefa(RepositorioTarefa _repositorio, ListagemTarefaControl _listagem) : base(_repositorio, _listagem)
        {
            this._repositorioTarefa = _repositorio;
            this._listagemTarefa = _listagem;
        }

        public override string ToolTipAdicionar { get { return "Adicionar nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override ListagemTarefaControl ObterListagem()
        {
            return _listagem;
        }
    }
}
