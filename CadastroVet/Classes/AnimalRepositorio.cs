using CadastroPet.Interfaces;
using System.Collections.Generic;
//Para usar o ToList
using System.Linq;

namespace CadastroPet.Classes
{
    public class AnimalRepositorio : IRepositorio<Animal>
    {
        //Decidi usar dicionario por parecer mais um banco de dados com id único e auto-incrementante
        private readonly Dictionary<int, Animal> dados;

        public AnimalRepositorio()
        {
            dados = new Dictionary<int, Animal>();
        }

        public void Atualizar(int id, Animal entidade)
        {
            if (dados.ContainsKey(id))
            {
                dados[id] = entidade;
            }
        }

        public void Excluir(int id)
        {
            if (dados.ContainsKey(id))
            {
                dados.Remove(id);
            }
        }

        public void Cadastrar(Animal entidade)
        {
            dados.Add(entidade.Id, entidade);
        }

        public List<Animal> Listar()
        {
            //ToList transforma uma coleção em List
            return dados.Values.ToList();
        }

        public Animal RetornarPorId(int id)
        {
            if (dados.ContainsKey(id))
            {
                return dados[id];
            }

            return null;
        }
    }
}
