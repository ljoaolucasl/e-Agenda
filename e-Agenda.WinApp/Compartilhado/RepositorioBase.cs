using System.Runtime.Serialization.Formatters.Binary;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : Entidade<TEntidade>
    {
        private List<TEntidade> listaRegistros = new();

        private int id = 1001;

        private string CaminhoArquivo => $"{typeof(TEntidade).Name}.bin";

        public int Id { get { return id; } }

        public RepositorioBase()
        {
            if (File.Exists(CaminhoArquivo))
                CarregarRegistrosDoArquivoBIN();
        }

        public void Adicionar(TEntidade registro)
        {
            registro.id = id; id++;
            listaRegistros.Add(registro);
            GravarRegistrosEmArquivoBIN();
        }

        public void Editar(TEntidade novoRegistro)
        {
            TEntidade registroAntigo = SelecionarId(novoRegistro.id);

            foreach (var atributo in registroAntigo.GetType().GetFields())
            {
                if (atributo.Name != "id")
                    atributo.SetValue(registroAntigo, atributo.GetValue(novoRegistro));
            }

            foreach (var property in registroAntigo.GetType().GetProperties())
            {
                if (property.Name != "Id")
                    property.SetValue(registroAntigo, property.GetValue(novoRegistro));
            }

            GravarRegistrosEmArquivoBIN();
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);

            GravarRegistrosEmArquivoBIN();
        }

        public TEntidade SelecionarId(int idEscolhido)
        {
            return listaRegistros.Find(e => e.id == idEscolhido);
        }

        public List<TEntidade> ObterListaRegistros()
        {
            return listaRegistros;
        }

        public void GravarRegistrosEmArquivoBIN()
        {
            BinaryFormatter serializador = new();

            MemoryStream registroStream = new();

            serializador.Serialize(registroStream, listaRegistros);

            File.WriteAllBytes(CaminhoArquivo, registroStream.ToArray());
        }

        public void CarregarRegistrosDoArquivoBIN()
        {
            BinaryFormatter serializador = new();

            byte[] registroBytes = File.ReadAllBytes(CaminhoArquivo);

            MemoryStream registroStream = new MemoryStream(registroBytes);

            listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            id = listaRegistros.Max(e => e.id) + 1;
        }
    }
}
