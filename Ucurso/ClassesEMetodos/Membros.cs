using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
    class Membros
    {
        public static void executar()
        {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Rafaela";
            sicrano.Idade = 17;

            // Console.WriteLine($"Meu nome é {sicrano.Nome} e idade é {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Rafa";
            fulano.Idade = 17;

            var apresentaFulano = fulano.Apresentar();
        }
    }
}
