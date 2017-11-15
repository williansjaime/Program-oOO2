using Receitas.Modelo.Entidades;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Modelo.Repositorio
{
    public class Pessoarepo
    {
        private Contexto  ctx = new Contexto();

        public void Adicionar(Pessoas pessoa)
        {
            
            ctx.pessoaDb.Add(pessoa);
            ctx.SaveChanges(); //pra salvar no banco de dados

        }

        public List<Pessoas> Listartodos()
        {
            
            return ctx.pessoaDb.ToList();

        }

        public void Remover(Pessoas pessoa)
        {
            
            ctx.pessoaDb.Remove(pessoa);
            ctx.SaveChanges();
        }
    }
}
