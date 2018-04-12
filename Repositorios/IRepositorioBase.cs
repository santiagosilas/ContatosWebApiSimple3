using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContatosWebApi.Models;

namespace ContatosWebApi.Repositorios
{
    public interface IRepositorioBase<T> where T : class, IEntidade
    {
        void Add(T entidade);
        IEnumerable<T> GetAll();
        T Find(long id);
        void Remove(long id);
        void Update(T entidade);
    }
}
