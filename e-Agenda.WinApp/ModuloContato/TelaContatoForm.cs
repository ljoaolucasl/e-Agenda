using e_Agenda.WinApp.Compartilhado;
using System.Text.RegularExpressions;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form, ITelaBase<Contato>
    {
        private Contato _contato;

        public TextBox TtxtId { get { return txtId; } }

        public Contato? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.telefone;
                txtEmail.Text = value.email;
                txtCargo.Text = value.cargo;
                txtEmpresa.Text = value.empresa;
            }
            get
            {
                return _contato;
            }
        }
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _contato = new Contato(txtNome.Text, txtTelefone.Text, txtEmail.Text, txtCargo.Text, txtEmpresa.Text);

            if (_contato.id == 0)
                _contato.id = int.Parse(txtId.Text);
        }


        private void Validacoes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Contato contato = new();

            int contatorErros = 0;

            if (contato.ValidarCampoVazio((Control)sender, avisoErro))
                contatorErros++;

            if (ValidarTelefone(txtTelefone))
                contatorErros++;

            if (ValidarEmail(txtEmail))
                contatorErros++;

            if (contatorErros == 3)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            contatorErros = 0;
        }

        private bool ValidarEmail(Control email)
        {
            if (Regex.IsMatch(email.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                avisoErro.SetError(email, "");
                email.BackColor = SystemColors.Window;
                return true;
            }
            else
            {
                avisoErro.SetError(email, "E-Mail inválido");
                email.BackColor = SystemColors.Info;
                return false;
            }
        }

        private bool ValidarTelefone(Control telefone)
        {
            if (Regex.IsMatch(telefone.Text, @"^\(\d{2}\) \d{4,5}-\d{4}$"))
            {
                avisoErro.SetError(telefone, "");
                telefone.BackColor = SystemColors.Window;
                return true;
            }
            else
            {
                avisoErro.SetError(telefone, "Telefone inválido");
                telefone.BackColor = SystemColors.Info;
                return false;
            }
        }
    }
}
