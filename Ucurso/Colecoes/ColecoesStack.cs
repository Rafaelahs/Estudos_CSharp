using System;
using System.Collections;
using System.Text;

namespace Ucurso.Colecoes
{
    class ColecoesStack
    {
        public static void executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.13f);


            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop : {pilha.Pop()} ");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek:{pilha.Peek()}");
            Console.WriteLine(pilha.Count);

        }
    }
}
