using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }





        public static void executar()
        {
            Formatar(mes: 04, dia: 13, ano: 2004);
        }
    }
}
