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

        public override void Editar()
        {
            Compromisso? compromisso = _listagemCompromisso.ObterContatoSelecionado();

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

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

                _listagemCompromisso.AtualizarLista(_repositorioCompromisso.ObterListaRegistros());
            }
        }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            telaCompromisso.txtId.Text = _repositorioCompromisso.Id.ToString();

            telaCompromisso.cbContato.DisplayMember = "nome";
            telaCompromisso.cbContato.ValueMember = "nome";

            telaCompromisso.cbContato.DataSource = _repositorioContato.ObterListaRegistros();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso? compromisso = telaCompromisso.Compromisso;

                _repositorioCompromisso.Adicionar(compromisso);

                _listagemCompromisso.AtualizarLista(_repositorioCompromisso.ObterListaRegistros());
            }
        }

        public override void CarregarRegistros()
        {
            _listagemCompromisso.AtualizarLista(_repositorioCompromisso.ObterListaRegistros());
        }

        public override ListagemCompromissoControl ObterListagem()
        {
            return _listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }
    }
}
