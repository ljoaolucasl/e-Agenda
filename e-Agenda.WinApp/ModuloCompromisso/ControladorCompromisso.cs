using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso _repositorioCompromisso;
        private RepositorioContato _repositorioContato;
        private ListagemCompromissoControl _listagemCompromisso = new();

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            _repositorioCompromisso = repositorioCompromisso;
            _repositorioContato = repositorioContato;
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
                Compromisso? compromisso = telaCompromisso.Compromisso;

                _repositorioCompromisso.Adicionar(compromisso);

                CarregarRegistros();
            }
        }

        public override void Editar()
        {
            Compromisso? compromisso = _listagemCompromisso.ObterContatoSelecionado();

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            CarregarContatosComboBox(telaCompromisso);

            telaCompromisso.Compromisso = compromisso;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioCompromisso.Editar(telaCompromisso.Compromisso);

                CarregarRegistros();
            }
        }

        public override void Excluir()
        {
            Compromisso? compromisso = _listagemCompromisso.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromisso.assunto}?", "Exclusão de Compromissos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _repositorioCompromisso.Excluir(compromisso);

                CarregarRegistros();
            }
        }

        public override void CarregarRegistros()
        {
            _listagemCompromisso.AtualizarLista(_repositorioCompromisso.ObterListaRegistros());
        }

        private void CarregarContatosComboBox(TelaCompromissoForm telaCompromisso)
        {
            telaCompromisso.cbContato.DisplayMember = "Nome";
            telaCompromisso.cbContato.ValueMember = "Nome";
            telaCompromisso.cbContato.DataSource = _repositorioContato.ObterListaRegistros();
        }

        public override ListagemCompromissoControl ObterListagem()
        {
            return _listagemCompromisso;
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
    }
}
