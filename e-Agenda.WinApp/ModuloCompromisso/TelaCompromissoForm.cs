using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form, ITelaBase<Compromisso>
    {
        private Compromisso _compromisso;

        public TextBox TtxtId { get { return txtId; } }

        public Compromisso? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                dtData.Text = value.data;
                dtInicio.Text = value.inicio;
                dtFinal.Text = value.final;
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

            _compromisso = new Compromisso(txtAssunto.Text, dtData.Text, dtInicio.Text, dtFinal.Text, contato, localizacao, remoto);

            if (_compromisso.id == 0)
                _compromisso.id = int.Parse(txtId.Text);
        }

        private void checkContatoBool_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContato.Checked)
                cbContato.Enabled = true;
            else
            {
                cbContato.Enabled = false;
                cbContato.SelectedIndex = -1;
            }
        }

        private void Validacoes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Compromisso compromisso = new();

            int contatorErros = 0;

            if (compromisso.ValidarCampoVazio(txtAssunto, avisoErro))
                contatorErros++;

            if (ValidarData(dtData))
                contatorErros++;

            if (ValidarHorarioInicioTermino(dtInicio, dtFinal))
                contatorErros++;

            if (ValidarContato(cbContato, checkContato))
                contatorErros++;

            if (ValidarLocalizacao(txtRemoto, txtPresencial, radioRemoto))
                contatorErros++;

            if (contatorErros == 5)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            contatorErros = 0;
        }

        private bool ValidarLocalizacao(TextBox txtRemoto, TextBox txtPresencial, RadioButton radioRemoto)
        {
            avisoErro.SetError(txtRemoto, "");
            txtRemoto.BackColor = SystemColors.Window;

            avisoErro.SetError(txtPresencial, "");
            txtPresencial.BackColor = SystemColors.Window;

            if (radioRemoto.Checked)
            {
                if (!string.IsNullOrEmpty(txtRemoto.Text))
                {
                    avisoErro.SetError(txtRemoto, "");
                    txtRemoto.BackColor = SystemColors.Window;
                    return true;
                }
                else
                {
                    avisoErro.SetError(txtRemoto, "Campo inválido");
                    txtRemoto.BackColor = SystemColors.Info;

                    avisoErro.SetError(txtPresencial, "");
                    txtPresencial.BackColor = SystemColors.Window;
                    return false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPresencial.Text))
                {
                    avisoErro.SetError(txtPresencial, "");
                    txtPresencial.BackColor = SystemColors.Window;
                    return true;
                }
                else
                {
                    avisoErro.SetError(txtPresencial, "Campo inválido");
                    txtPresencial.BackColor = SystemColors.Info;

                    avisoErro.SetError(txtRemoto, "");
                    txtRemoto.BackColor = SystemColors.Window;
                    return false;
                }
            }
        }

        private bool ValidarContato(ComboBox contato, CheckBox check)
        {
            if (check.Checked)
            {
                if (string.IsNullOrEmpty(cbContato.Text))
                {
                    avisoErro.SetError(contato, "Selecione um Contato");
                    contato.BackColor = SystemColors.Info;
                    return false;
                }
                else
                {
                    avisoErro.SetError(contato, "");
                    contato.BackColor = SystemColors.Window;
                    return true;
                }
            }
            else
            {
                avisoErro.SetError(contato, "");
                contato.BackColor = SystemColors.Window;
                return true;
            }

        }

        private bool ValidarData(DateTimePicker data)
        {
            if (data.Value.Date >= DateTime.Today)
            {
                avisoErro.SetError(data, "");
                data.BackColor = SystemColors.Window;
                return true;
            }
            else
            {
                avisoErro.SetError(data, "Não é possível colocar uma data anterior a data de hoje");
                data.BackColor = SystemColors.Info;
                return false;
            }
        }

        private bool ValidarHorarioInicioTermino(DateTimePicker horarioInicio, DateTimePicker horarioFinal)
        {
            if (horarioInicio.Value.TimeOfDay <= horarioFinal.Value.TimeOfDay)
            {
                avisoErro.SetError(horarioFinal, "");
                horarioFinal.BackColor = SystemColors.Window;
                return true;
            }
            else
            {
                avisoErro.SetError(horarioFinal, "Horário final não pode ser menor do que o horário inicial");
                horarioFinal.BackColor = SystemColors.Info;
                return false;
            }
        }
    }
}
