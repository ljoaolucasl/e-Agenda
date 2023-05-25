using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDespesas;
using System.ComponentModel;
using System.Xml.Linq;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form, ITelaBase<Categoria>
    {
        private Categoria _categoria;

        public TextBox TtxtId { get { return txtId; } }

        public Categoria? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
            }
            get
            {
                return _categoria;
            }
        }

        public TelaCategoriaForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _categoria = new Categoria(txtTitulo.Text);

            if (_categoria.id == 0)
                _categoria.id = int.Parse(txtId.Text);
        }

        private void Validacoes_Validating(object sender, CancelEventArgs e)
        {
            Categoria categoria = new();

            int contatorErros = 0;

            if (categoria.ValidarCampoVazio(txtTitulo, avisoErro))
                contatorErros++;

            if (contatorErros == 1)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            contatorErros = 0;
        }
    }
}
