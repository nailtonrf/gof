using System;
using Patterns_OO.Criacionais;
using Patterns_OO.Estruturais;
using Patterns_OO.Comportamentais;

namespace Patterns_OO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Padroes_Criacionais.Apresentar();

            Padroes_Estruturais.Apresentar();

            Padroes_Comportamentais.Apresentar();

            Console.ReadKey();
        }
    }
}