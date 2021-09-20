using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            double desconto = 0.1;

            string nome;
            public string Nome
            {
                get
                {
                    return "Opcional:" + nome;
                }
                set
                {
                    nome = value;
                }
            }


            // Propriedade autoimplementada
            public double Preco { get; set; }

            // Somente leitura
            public double PrecoComDesconto
            {
                get => Preco - (desconto * Preco); //Lambda
            }

            public CarroOpcional()
            {

            }


     

            public  CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }



        }




        public static void executar()
        {
            var opcional1 = new CarroOpcional("Ar Condicionado", 3499.666);

            Console.WriteLine(opcional1.PrecoComDesconto);

            var opcional2 = new CarroOpcional();
            opcional2.Nome = "Direção Elétrica";
            opcional2.Preco = 336.9;

            Console.WriteLine(opcional1.Nome);
            Console.WriteLine(opcional1.Preco);

            Console.WriteLine(opcional2.Nome);
            Console.WriteLine(opcional2.Preco);



        }
    }
}
