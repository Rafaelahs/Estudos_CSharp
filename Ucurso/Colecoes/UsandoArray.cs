using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.Colecoes
{
    class UsandoArray
    {

        public static void executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Maria";
            alunos[2] = "Andre";
            alunos[3] = "Mario";
            alunos[4] = "Marcio";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 10, 10, 10, 10, 10, 10 };

            foreach ( var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);


        }

    }
}
