using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.name = "jamal";
            emp1.surname = "guliyev";
          
            emp1.position = "manager";
            emp1.salary  = 50;

            Console.WriteLine($"{emp1.name}, {emp1.surname}, {emp1.position} ");
            emp1.Sum();






        }
    }    
}
