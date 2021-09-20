using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.Colecoes
{
   
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
    }
    
        
    class ColecoesList
    {
        public static void executar()
        {
            var livro = new Produto("Larissa Manoela", 98.05);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("camisa", 36.08),
                new Produto("bola", 25.08),
                new Produto("chuteira", 85.90)

            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) 
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome}  {item.Preco} ");
            }


        }
    }
}
