using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
   
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto (string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }



    }
    
    
    
    
    
    
    class AtributosEstaticos
    {
        public static void executar()
        {
            var produto = new Produto("Caneta",3.6,1.6);

            var produto1 = new Produto()
            {
                Nome = "Livro",
                Preco = 5.9,
                Desconto = 2.0

            };

            Console.WriteLine("Preço com desconto: {0}",produto.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());


        }
    }
}
