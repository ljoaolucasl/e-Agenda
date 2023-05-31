using System.Runtime.Serialization.Formatters.Binary;

namespace e_Agenda.WinApp.Compartilhado
{
    public class RepositorioGlobal
    {
        public static List<object>? Dados {  get; set; }

        public const string CAMINHO_ARQUIVO = "e-agenda.bin";

        public RepositorioGlobal(List<object> dados)
        {
            Dados = dados;
        }

        public static void GravarRegistrosEmArquivoBIN()
        {
            BinaryFormatter serializador = new();

            MemoryStream registroStream = new();

            serializador.Serialize(registroStream, Dados);

            File.WriteAllBytes(CAMINHO_ARQUIVO, registroStream.ToArray());
        }

        public static void CarregarRegistrosDoArquivoBIN()
        {
            BinaryFormatter serializador = new();

            byte[] registroBytes = File.ReadAllBytes(CAMINHO_ARQUIVO);

            MemoryStream registroStream = new MemoryStream(registroBytes);

            Dados = (List<object>)serializador.Deserialize(registroStream);
        }
    }
}
