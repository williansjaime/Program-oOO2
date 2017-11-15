using Receitas.Modelo.Entidades;
using Receitas.Modelo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositorio = new Pessoarepo();
            var pessoa = new Pessoas();
            pessoa.Nome = "wii";
            pessoa.CPF = 1111111;

            repositorio.Adicionar(pessoa);
            var pessoa2 = repositorio.Listartodos().FirstOrDefault();

            Console.WriteLine(repositorio.Listartodos().Count);

        }
    }
}
