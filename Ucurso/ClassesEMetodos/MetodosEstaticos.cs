using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
  
    public class CalculadoraEstatica
    {
        // Metodo Estatico
        public static int Somar(int a, int b)
        {
            return a + b;
        }
          // Método de instância
        public  int subtracao(int a, int b)
        {
            return a - b;
        }
        // Metodo Estatico
        public static int multiplicar(int a, int b)
        {
            return a * b;
        }

    }
    
    
    
    class MetodosEstaticos
    {
        public static void executar()
        {
            var calculadoraEstatica = CalculadoraEstatica.Somar(6, 3);
            Console.WriteLine("Resultado {0}", calculadoraEstatica);

            Console.WriteLine(CalculadoraEstatica.multiplicar(10,9));

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.subtracao(10, 9));


        }
    }
}
