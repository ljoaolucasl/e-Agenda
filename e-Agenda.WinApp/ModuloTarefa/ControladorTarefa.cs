using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa.Item;

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

        public override void AdicionarItens()
        {
            TelaItemForm telaItem = new();
            Tarefa tarefaSelecionada = null;

            foreach (ListViewItem tarefa in _listagemTarefa.ListView.SelectedItems)
            {
                telaItem.lbTarefa.Text = tarefa.SubItems[1].Text;
                tarefaSelecionada = (Tarefa)tarefa.Tag;
            }

            telaItem.Entidade = tarefaSelecionada.itens;

            TelaPrincipalForm.AtualizarStatus($"Cadastrando Itens");

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioTarefa.AdicionarItemTarefa(tarefaSelecionada, telaItem.Entidade);

            }
                CarregarRegistros();
        }

        public override void AtualizarItensCheck()
        {
            TelaItemCheckForm telaItemCheck = new();
            Tarefa tarefaSelecionada = null;

            int qtdItensAtualizados = 0;

            foreach (ListViewItem tarefa in _listagemTarefa.ListView.SelectedItems)
            {
                telaItemCheck.lbTarefa.Text = tarefa.SubItems[1].Text;
                tarefaSelecionada = (Tarefa)tarefa.Tag;
            }

            telaItemCheck.Entidade = tarefaSelecionada.itens;

            TelaPrincipalForm.AtualizarStatus($"Atualizando Itens");

            DialogResult opcaoEscolhida = telaItemCheck.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                foreach (string itemCheck in telaItemCheck.checkListItens.CheckedItems)
                {
                    foreach (ItemTarefa item in tarefaSelecionada.itens)
                    {
                        if (item.nome == itemCheck)
                            item.check = true;
                    }

                    qtdItensAtualizados++;
                }

                _repositorioTarefa.AtualizarItens(tarefaSelecionada, qtdItensAtualizados);

            }
            CarregarRegistros();
        }

        public override void Filtrar()
        {
            TelaFiltroTarefaForm telaFiltroTarefa = new();

            TelaPrincipalForm.AtualizarStatus($"Filtrando Tarefas");

            DialogResult opcaoEscolhida = telaFiltroTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                FiltroTarefa filtroSelecionado = telaFiltroTarefa.FiltroSelecionado;

                CarregarTarefasComFiltro(filtroSelecionado);
            }
            else
                CarregarRegistros();
        }

        private void CarregarTarefasComFiltro(FiltroTarefa filtroSelecionado)
        {
            List<Tarefa> listaFiltrada = new List<Tarefa>();

            switch (filtroSelecionado)
            {
                case FiltroTarefa.Todos:
                    listaFiltrada = _repositorioTarefa.ObterListaRegistros();
                    break;
                case FiltroTarefa.Pendentes:
                    listaFiltrada = _repositorioTarefa.FiltrarTarefasPendentes();
                    break;
                case FiltroTarefa.Concluidas:
                    listaFiltrada = _repositorioTarefa.FiltrarTarefasConcluidas();
                    break;
            }

            _listagemTarefa.AtualizarLista(listaFiltrada);
        }

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
