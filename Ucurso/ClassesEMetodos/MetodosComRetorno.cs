using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{

    class CalculadoraComum { 
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subitrair(int c, int d)
        {
            return c - d;
        }

        public int multiplicar(int c, int d)
        {
            return c * d;
        }

    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;

        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine($"Calculadora CAdeia {memoria} ");
            return this;
        }

        public int resultado()
        {
            return memoria;
        }

    }
  




    class MetodosComRetorno
    {
        public static void executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine($"Resultado {resultado}");
            Console.WriteLine($"Subtrair {calculadoraComum.Subitrair(3,2)}");
            Console.WriteLine($"Multiplicar {calculadoraComum.multiplicar(9,9)}");

            var calculadoraCadeia = new CalculadoraCadeia();

            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
        }
    }
}
