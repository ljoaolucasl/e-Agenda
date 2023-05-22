namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class Entidade
    {
        public int id;

        public bool ValidarCampoVazio(Control control, ErrorProvider avisoErro)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                avisoErro.SetError(control, "Campo Obrigatório");
                control.BackColor = SystemColors.Info;
                return false;
            }
            else
            {
                avisoErro.SetError(control, "");
                control.BackColor = SystemColors.Window;
                return true;
            }
        }
    }
}