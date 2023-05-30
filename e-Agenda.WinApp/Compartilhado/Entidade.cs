namespace e_Agenda.WinApp.Compartilhado
{
    [Serializable]
    public abstract class Entidade<TEntidade>
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

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            foreach (var atributo in GetType().GetFields())
            {
                if (!Equals(atributo.GetValue((TEntidade)obj), atributo.GetValue(this)))
                    return false;
            }
            return true;
        }
    }
}