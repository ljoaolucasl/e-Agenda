
namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato _contato;

        public Contato? Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
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
    }
}
