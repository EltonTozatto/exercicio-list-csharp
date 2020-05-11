using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> listEmployees = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployees.Add(new Employee() { Id = id, Name = name, Salary = salary});
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increased: ");
            int idIncrease = int.Parse(Console.ReadLine());
            int index = listEmployees.FindIndex(x => x.Id == idIncrease);
            
            if(index != -1)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployees[index].increaseSalary(percentage);
            }
            else
                Console.WriteLine("This id does not exist!");

            Console.WriteLine();
            Console.WriteLine("Update list of employees");

            foreach(Employee employee in listEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
