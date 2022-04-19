using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class GenericList
    {
       public static void Main(String[] args)
        {
            List<string> employee = new List<string>();

            employee.Add("Ram");
            employee.Add("Shamh");
            employee.Add("Nagesh");
            employee.Add("Soham");

            Console.WriteLine("Employee Details are : ");
            foreach (var value in employee)
                Console.WriteLine(value);

            Console.WriteLine("\nTotal number of Employes are: " + employee.Count);
            Console.ReadLine();
        }
    }
}
