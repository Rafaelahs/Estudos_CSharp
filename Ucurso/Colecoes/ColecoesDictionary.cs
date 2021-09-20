using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.Colecoes
{
    class ColecoesDictionary
    {
        public static void executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem aranha");
            filmes.Add(2006, "Grande truque");

            if (filmes.ContainsKey(2006))
            {
                Console.WriteLine("2006:" + filmes[2006]);
                Console.WriteLine("2006:" + filmes.GetValueOrDefault(2006));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine($"Removeu? {filmes.Remove(2002)}");

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"filme {filme2006}!");

            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach(KeyValuePair<int, string>  filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"Filme: {filme.Value} é de {filme.Key}.");
            }

        }
    }
}
