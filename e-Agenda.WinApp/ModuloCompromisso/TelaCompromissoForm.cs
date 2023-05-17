
namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso _compromisso;

        public Compromisso? Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                dtData.Text = value.data;
                dtInicio.Text = value.inicio;
                dtTermino.Text = value.termino;
                cbContato.Text = value.contato;
            }
            get
            {
                return _compromisso;
            }
        }

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _compromisso = new Compromisso(txtAssunto.Text, dtData.Text, dtInicio.Text, dtTermino.Text, cbContato.Text);

            if (_compromisso.id == 0)
                _compromisso.id = int.Parse(txtId.Text);
        }
    }
}
