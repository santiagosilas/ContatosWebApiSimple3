using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContatosWebApi.Models;

namespace ContatosWebApi.Repositorios
{
    public class ContatoRepositorio: RepositorioBase<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(DataContext context) : base(context)
        {
        }
    }
}
