using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
    class  DesafioAtributo
    {
        int a = 10;


        public static void executar()
        {
            var b = new DesafioAtributo();
            

            Console.WriteLine($"Valor: {b.a}");


        }
    }
}
