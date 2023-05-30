using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa.Item;
using System.Collections;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase<Tarefa, RepositorioTarefa, TabelaTarefaControl, TelaTarefaForm, NenhumRepositorio>
    {
        private RepositorioTarefa _repositorioTarefa;
        private TabelaTarefaControl _tabelaTarefa;

        public ControladorTarefa(RepositorioTarefa _repositorio, TabelaTarefaControl _tabela) : base(_repositorio, _tabela)
        {
            this._repositorioTarefa = _repositorio;
            this._tabelaTarefa = _tabela;
        }

        public override void AdicionarItens()
        {
            TelaItemForm telaItem = new();
            Tarefa tarefaSelecionada = null;

            tarefaSelecionada = _tabelaTarefa.ObterTarefaSelecionada();

            telaItem.lbTarefa.Text = tarefaSelecionada.titulo;

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

            //foreach (ListViewItem tarefa in _tabelaTarefa.ListView.SelectedItems)
            //{
            //    telaItemCheck.lbTarefa.Text = tarefa.SubItems[1].Text;
            //    tarefaSelecionada = (Tarefa)tarefa.Tag;
            //}

            tarefaSelecionada = _tabelaTarefa.ObterTarefaSelecionada();

            telaItemCheck.lbTarefa.Text = tarefaSelecionada.titulo;


            telaItemCheck.Entidade = tarefaSelecionada.itens;

            TelaPrincipalForm.AtualizarStatus($"Atualizando Itens");

            DialogResult opcaoEscolhida = telaItemCheck.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                for (int i = 0; i < tarefaSelecionada.itens.Count; i++)
                {
                    if (telaItemCheck.checkListItens.GetItemChecked(i))
                    {
                        tarefaSelecionada.itens[i].check = true;
                        qtdItensAtualizados++;
                    }
                    else
                        tarefaSelecionada.itens[i].check = false;
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

            _tabelaTarefa.AtualizarLista(listaFiltrada);
        }

        public override TabelaTarefaControl ObterListagem()
        {
            return _tabela;
        }
    }
}
