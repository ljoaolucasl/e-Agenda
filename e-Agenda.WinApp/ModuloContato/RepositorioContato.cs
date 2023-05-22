using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato()
        {
            Contato contato1 = new Contato("José Pedro", "(49)99954-8712", "josepedro1@gmail.com", "Padeiro", "Panificadora Silva");
            Adicionar(contato1);

            Contato contato2 = new Contato("Maria Pereira", "(49)99967-3452", "mpereiraa@gmail.com", "Dentista", "Odonto Pass");
            Adicionar(contato2);

            Contato contato3 = new Contato("Lucas Mota", "(49)99923-2266", "lucmota@gmail.com", "Analista Chefe", "CTech");
            Adicionar(contato3);

            Contato contato4 = new Contato("Carla Moraes", "(49)99933-5621", "carla2002@gmail.com", "Especialista em Moda", "Style Brasil");
            Adicionar(contato4);
        }
    }
}
