using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return String.Format($"Olá Me chamo {Nome} e tenho {Idade} anos");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
