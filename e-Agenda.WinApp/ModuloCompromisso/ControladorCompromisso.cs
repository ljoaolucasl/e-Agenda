using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase<Compromisso, RepositorioCompromisso, ListagemCompromissoControl, TelaCompromissoForm>
    {
        private RepositorioCompromisso _repositorioCompromisso;
        private RepositorioContato _repositorioContato;
        private ListagemCompromissoControl _listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso _repositorio, ListagemCompromissoControl _listagem, RepositorioContato _repositorioContato) : base(_repositorio, _listagem, _repositorioContato)
        {
            this._repositorioCompromisso = _repositorio;
            this._listagemCompromisso = _listagem;
            this._repositorioContato = _repositorioContato;
        }

        public override string ToolTipAdicionar { get { return "Adicionar novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato existente"; } }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            telaCompromisso.txtId.Text = _repositorioCompromisso.Id.ToString();

            CarregarContatosComboBox(telaCompromisso);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso? compromisso = telaCompromisso.Entidade;

                _repositorioCompromisso.Adicionar(compromisso);

                CarregarRegistros();
            }
        }

        public override void Editar()
        {
            Compromisso? compromisso = _listagemCompromisso.ObterContatoSelecionado();

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            CarregarContatosComboBox(telaCompromisso);

            telaCompromisso.Entidade = compromisso;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioCompromisso.Editar(telaCompromisso.Entidade);

                CarregarRegistros();
            }
        }

        private void CarregarContatosComboBox(TelaCompromissoForm telaCompromisso)
        {
            telaCompromisso.cbContato.DisplayMember = "Nome";
            telaCompromisso.cbContato.ValueMember = "Nome";
            telaCompromisso.cbContato.DataSource = _repositorioContato.ObterListaRegistros();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltroCompromisso = new();

            DialogResult opcaoEscolhida = telaFiltroCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                FiltroCompromisso filtroSelecionado = telaFiltroCompromisso.FiltroSelecionado;
                DateTime dataInicial = telaFiltroCompromisso.DataInicial.Date;
                DateTime dataFinal = telaFiltroCompromisso.DataFinal.Date;

                CarregarCompromissosComFiltro(filtroSelecionado, dataInicial, dataFinal);
            }
        }

        private void CarregarCompromissosComFiltro(FiltroCompromisso filtroSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> listaFiltrada = new List<Compromisso>();

            switch (filtroSelecionado)
            {
                case FiltroCompromisso.Todos: listaFiltrada = _repositorioCompromisso.ObterListaRegistros();
                    break;
                case FiltroCompromisso.Passados: listaFiltrada = _repositorioCompromisso.FiltrarCompromissosPassados(DateTime.Now);
                    break;
                case FiltroCompromisso.Futuros: listaFiltrada = _repositorioCompromisso.FiltrarCompromissosFuturos(dataInicial, dataFinal);
                    break;
            }

            _listagemCompromisso.AtualizarLista(listaFiltrada);
        }

        public override ListagemCompromissoControl ObterListagem()
        {
            return _listagem;
        }
    }
}
