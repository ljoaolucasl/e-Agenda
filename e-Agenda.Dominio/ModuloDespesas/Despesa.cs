using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.Dominio.ModuloDespesas
{
    [Serializable]
    public class Despesa : Entidade<Despesa>
    {
        public string descricao;
        public string valor;
        public string data;
        public string formaPagamento;
        public List<Categoria> categorias = new();

        public Despesa(string descricao, string valor, string data, string formaPagamento)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.formaPagamento = formaPagamento;
        }

        public Despesa()
        {
            
        }

        public override string? ToString()
        {
            return descricao + " realizado no dia " + data;
        }
    }
}
