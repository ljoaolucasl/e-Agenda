namespace e_Agenda.WinApp.Compartilhado
{
    public interface ITelaBase<TEntidade> where TEntidade : Entidade<TEntidade>
    {
        TextBox TtxtId { get; }

        TEntidade? Entidade { get; set; }

        DialogResult ShowDialog();
    }
}
