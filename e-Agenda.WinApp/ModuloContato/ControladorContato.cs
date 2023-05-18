using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato _repositorioContato;
        private ListagemContatoControl _listagemContato = new();

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this._repositorioContato = repositorioContato;
        }

        public override string ToolTipAdicionar { get { return "Adicionar novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.txtId.Text = _repositorioContato.Id.ToString();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato? contato = telaContato.Contato;

                _repositorioContato.Adicionar(contato);

                CarregarRegistros();
            }
        }

        public override void Editar()
        {
            Contato? contato = _listagemContato.ObterContatoSelecionado();

            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.Contato = contato;

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioContato.Editar(telaContato.Contato);

                CarregarRegistros();
            }
        }

        public override void Excluir()
        {
            Contato? contato = _listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _repositorioContato.Excluir(contato);

                CarregarRegistros();
            }
        }

        public override void CarregarRegistros()
        {
            _listagemContato.AtualizarLista(_repositorioContato.ObterListaRegistros());
        }

        public override ListagemContatoControl ObterListagem()
        {
            return _listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }
    }
}
