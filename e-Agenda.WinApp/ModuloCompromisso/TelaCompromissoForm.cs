
using e_Agenda.WinApp.ModuloContato;

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
                cbContato.Text = value.contato == null ? "" : value.contato.nome;
                txtPresencial.Text = value.remoto ? "" : value.localizacao;
                txtRemoto.Text = value.remoto ? value.localizacao : "";
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
            Contato contato = cbContato.SelectedItem as Contato;

            string localizacao = radioPresencial.Checked == true ? txtPresencial.Text : txtRemoto.Text;

            bool remoto = radioPresencial.Checked == true ? false : true;

            _compromisso = new Compromisso(txtAssunto.Text, dtData.Text, dtInicio.Text, dtTermino.Text, contato, localizacao, remoto);

            if (_compromisso.id == 0)
                _compromisso.id = int.Parse(txtId.Text);
        }

        private void checkContatoBool_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContatoBool.Checked)
                cbContato.Enabled = true;
            else
            {
                cbContato.Enabled = false;
                cbContato.SelectedValue = "";
            }
        }
    }
}
