using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : Entidade
    {
        private List<TEntidade> listaRegistros = new();

        private int id = 1001;

        public int Id { get { return id; } }

        public void Adicionar(TEntidade registro)
        {
            registro.id = id; id++;
            listaRegistros.Add(registro);
        }

        public void Editar(TEntidade novoRegistro)
        {
            TEntidade entidadeSelecionada = SelecionarId(novoRegistro.id);

            if (entidadeSelecionada != null)
            {
                foreach (var atributo in entidadeSelecionada.GetType().GetFields())
                {
                    if (atributo.Name != "id")
                        atributo.SetValue(entidadeSelecionada, atributo.GetValue(novoRegistro));
                }
            }
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            TEntidade entidadeSelecionada = SelecionarId(registroSelecionado.id);

            if (entidadeSelecionada != null)
            {
                listaRegistros.Remove(entidadeSelecionada);
            }
        }

        public TEntidade SelecionarId(int idEscolhido)
        {
            return listaRegistros.Find(e => e.id == idEscolhido);
        }

        public List<TEntidade> ObterListaRegistros()
        {
            return listaRegistros;
        }
    }
}
