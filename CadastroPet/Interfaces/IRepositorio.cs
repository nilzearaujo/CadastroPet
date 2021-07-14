using System.Collections.Generic;

namespace CadastroPet.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornarPorId(int id);
        void Cadastrar(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);        
    }
}
