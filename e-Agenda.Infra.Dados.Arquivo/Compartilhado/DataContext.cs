using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloDespesas;
using e_Agenda.Dominio.ModuloTarefa;
using System.Runtime.Serialization.Formatters.Binary;

namespace e_Agenda.Infra.Dados.Arquivo.Compartilhado
{
    [Serializable]
    public class DataContext
    {
        private DataContext _dataContext;

        public DataContext()
        {
            Categorias = new List<Categoria>();

            Compromissos = new List<Compromisso>();

            Contatos = new List<Contato>();

            Despesas = new List<Despesa>();

            Tarefas = new List<Tarefa>();
        }

        public List<Categoria> Categorias { get; set; }

        public List<Compromisso> Compromissos { get; set; }

        public List<Contato> Contatos { get; set; }

        public List<Despesa> Despesas { get; set; }

        public List<Tarefa> Tarefas { get; set; }


        public const string CAMINHO_ARQUIVO = "e-agenda.bin";

        public void CarregarDados()
        {
            if (!File.Exists(CAMINHO_ARQUIVO))
                return;

            DataContext dataContext = CarregarRegistrosDoArquivoBIN();

            this.Categorias = dataContext.Categorias;
            this.Compromissos = dataContext.Compromissos;
            this.Contatos = dataContext.Contatos;
            this.Despesas = dataContext.Despesas;
            this.Tarefas = dataContext.Tarefas;
        }

        public void GravarRegistrosEmArquivoBIN()
        {
            BinaryFormatter serializador = new();

            MemoryStream registroStream = new();

            serializador.Serialize(registroStream, this);

            File.WriteAllBytes(CAMINHO_ARQUIVO, registroStream.ToArray());
        }

        public DataContext CarregarRegistrosDoArquivoBIN()
        {
  
            BinaryFormatter serializador = new();

            byte[] registroBytes = File.ReadAllBytes(CAMINHO_ARQUIVO);

            MemoryStream registroStream = new MemoryStream(registroBytes);

            return (DataContext)serializador.Deserialize(registroStream);
        }
    }
}
