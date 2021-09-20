using System;
using System.Collections.Generic;
using System.Text;

namespace Ucurso.ClassesEMetodos
{
   
   public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca; 
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        { 
            Cilindrada = cilindrada;
        }

    } 
    
    
    
    
    
    
    
    
    
    class GetSet
    {
        public static void executar()
        {
            var moto1 = new Moto("Kawasa","azul",386);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetCilindrada(123);
            moto2.SetModelo("Preta");

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());



        }
    }
}
