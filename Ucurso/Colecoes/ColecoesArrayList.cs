using System;
using System.Collections;


namespace Ucurso.Colecoes
{
    class ColecoesArrayList
    {
        public static void executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach(var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }


        }
    }
}
