using Patterns_OO.Estruturais.Adapter_Pattern;
using System;

namespace Patterns_OO.Estruturais
{
    public class Padroes_Estruturais
    {
        public static void Apresentar()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("PADROES ESTRUTURAIS");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Adapter");
            var adaptador = new AdapterEmployees();
            adaptador.GetEmployeeList().ForEach((item) =>
            {
                Console.WriteLine(item);
            });            

            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}