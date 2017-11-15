using Receitas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Modelo.Repositorio
{
    public class Contexto : DbContext  //E uma classe do ent framwork/sabe fazer todas as operaçoes do banco de dados
    {
        public DbSet<Pessoas> pessoaDb { get; set; } //todas as tabelas da class pessoa vai esta aki


    }
}
