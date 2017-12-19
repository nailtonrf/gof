using System.Collections.Generic;

namespace Patterns_OO.Estruturais.Adapter_Pattern
{
    public class AdapterEmployees : ServicoAntigo, IAdapterEmployees
    {
        /* Converta a interface de uma classe em outra interface que os clientes esperam. 
         * Envolva uma classe existente com uma nova interface. */
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add($"{employee[0]} - {employee[1]} - {employee[2]}");
            }

            return employeeList;
        }
    }

    public interface IAdapterEmployees
    {
        List<string> GetEmployeeList();
    }

    /// <summary>
    /// Classe adaptada
    /// </summary>
    public class ServicoAntigo
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Rohit", "Developer" };
            employees[2] = new string[] { "102", "Gautam", "Developer" };
            employees[3] = new string[] { "103", "Dev", "Tester" };

            return employees;
        }
    }
}