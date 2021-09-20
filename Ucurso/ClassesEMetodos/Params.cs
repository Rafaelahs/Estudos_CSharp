using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
    class Params
    {

        public static void Recepcionar(params string[] pessoas)
        {
            foreach( var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }




        public static void executar()
        {
            Recepcionar("Rafaela", "Rafa", "leão","Rato");
        }
    }
}
