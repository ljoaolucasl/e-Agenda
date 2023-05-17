using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private RepositorioTarefa _repositorioTarefa;
        private ListagemTarefaControl _listagemTarefa = new();

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this._repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipAdicionar { get { return "Adicionar nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override void Editar()
        {
            Tarefa? tarefa = _listagemTarefa.ObterContatoSelecionado();

            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            telaTarefa.Tarefa = tarefa;

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioTarefa.Editar(telaTarefa.Tarefa);

                CarregarRegistros();
            }
        }

        public override void Excluir()
        {
            Tarefa? tarefa = _listagemTarefa.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {tarefa.titulo}?", "Exclusão de Tarefas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _repositorioTarefa.Excluir(tarefa);

                _listagemTarefa.AtualizarLista(_repositorioTarefa.ObterListaRegistros());
            }
        }

        public override void Adicionar()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            telaTarefa.txtId.Text = _repositorioTarefa.Id.ToString();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa? tarefa = telaTarefa.Tarefa;

                _repositorioTarefa.Adicionar(tarefa);

                _listagemTarefa.AtualizarLista(_repositorioTarefa.ObterListaRegistros());
            }
        }

        public override void CarregarRegistros()
        {
            _listagemTarefa.AtualizarLista(_repositorioTarefa.ObterListaRegistros());
        }

        public override ListagemTarefaControl ObterListagem()
        {
            return _listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }
    }
}
