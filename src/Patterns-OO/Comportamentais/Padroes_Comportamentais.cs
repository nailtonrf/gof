using Patterns_OO.Comportamentais.Visitor_Pattern;
using System;

namespace Patterns_OO.Comportamentais
{
    public class Padroes_Comportamentais
    {
        public static void Apresentar()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("PADROES COMPORTAMENTAIS");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Visitor");
            var rendaVisitor = new CalculadorRendaVisitor();
            var feriasVisitor = new CalculadorFeriasVisitor();
            var colaboradorJoao = new Colaborador("Joao", 1000, 10);
            colaboradorJoao.Accept(rendaVisitor);
            colaboradorJoao.Accept(feriasVisitor);
        }
    }
}