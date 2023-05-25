using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloTarefa.Item;
using System.ComponentModel;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaDespesaForm : Form, ITelaBase<Despesa>
    {
        private Despesa _despesa;

        public TextBox TtxtId { get { return txtId; } }

        public Despesa? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricao;
                txtValor.Text = value.valor;
                dtData.Text = value.data;
                cbPagamento.Text = value.formaPagamento;

                if (value.categorias != null)
                {
                    foreach (Categoria itemCheck in value.categorias)
                    {
                        for (int i = 0; i < checkListCategorias.Items.Count; i++)
                        {
                            if (itemCheck == checkListCategorias.Items[i])
                                checkListCategorias.SetItemChecked(i, true);
                        }
                    }
                }
            }
            get
            {
                return _despesa;
            }
        }

        public TelaDespesaForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _despesa = new Despesa(txtDescricao.Text, txtValor.Text, dtData.Text, cbPagamento.Text);

            _despesa.categorias = checkListCategorias.CheckedItems.Cast<Categoria>().ToList();

            if (_despesa.id == 0)
                _despesa.id = int.Parse(txtId.Text);
        }

        private void txtValor_ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && (txtValor.Text == "" || txtValor.Text.Contains(",")))
                e.Handled = true;
        }

        private void Validacoes_Validating(object sender, CancelEventArgs e)
        {
            Despesa despesa = new();

            int contatorErros = 0;

            if (despesa.ValidarCampoVazio(txtDescricao, avisoErro))
                contatorErros++;

            if (despesa.ValidarCampoVazio(txtValor, avisoErro))
                contatorErros++;

            if (despesa.ValidarCampoVazio(cbPagamento, avisoErro))
                contatorErros++;

            if (contatorErros == 3)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            contatorErros = 0;
        }

    }
}
