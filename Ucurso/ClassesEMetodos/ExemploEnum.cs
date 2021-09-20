using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{



    public enum Genero { Acao, Aventura, Terro, Comédia, Animacao };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;

    }



    class ExemploEnum
    {
       

        public static void executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmePraFamilia = new Filme();
            filmePraFamilia.Titulo = "Aventuras de PI";
            filmePraFamilia.GeneroDoFilme = Genero.Aventura;

            Console.WriteLine("{0} é {1}!", filmePraFamilia.Titulo, filmePraFamilia.GeneroDoFilme);

        } 
    }
}
