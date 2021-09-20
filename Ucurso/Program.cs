using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;

using Ucurso.ClassesEMetodos;
using Ucurso.Colecoes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new Ucurso.CentralDeExercicios(new Dictionary<string, Action>() {
         
                // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.executar},
                {"Construtores - Classes e Métodos", Construtores.executar},
                {"Metodos com Retorno - Classes e Métodos", MetodosComRetorno.executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.executar},
                {"Desafio atributo - Classes e Metodos", DesafioAtributo.executar},
                {"Parametros Variaveis - Classes e Metodos ", Params.executar},
                {"Parametros Nomeados - Classes e metodos", ParametrosNomeados.executar},
                {"Get Set - Classes e Métodos", GetSet.executar},
                { "Props - Classes e Métodos", Props.executar},
                {"Readonly - Classes e Métodos", Readonly.executar},
                {"Enum - Classes e Métodos", ExemploEnum.executar},
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct  VS Classes - Classes e Métodos", StructVsClasses.Executar},

                // Coleções

                {"Usando Array - Coleções ", UsandoArray.executar},
                {"list - Coleções ", ColecoesList.executar},
                {" Array Lista  - Coleções", ColecoesArrayList.executar},
                {"Queue - Coleções", ColecoesQueue.executar},
                {"Igualdade - Coleções", Igualdade.executar},
                {"Stack - Coleções", ColecoesStack.executar},
                {"Dictionary - Coleções", ColecoesDictionary.executar},




            });

            central.SelecionarEExecutar();
        }
    }
}
