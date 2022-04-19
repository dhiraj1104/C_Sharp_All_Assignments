using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerialization
{
    
    public class Employee
    {
        public int empId = 011;
        public string empName = "Dhiraj";
        public string empDesignation = "ANALYSTA4";

    }
    public class Manager1
    {
        public int managerId = 205;
        public String managerName = "Neeta Disilva";
        public double managerBasicPayScale = 60000;

    }
    public class MarketingExecutive
    {
        public int markExId = 1011;
        public String markExName = "Sam Thakur";
        public String markExDesignation = "BCR";

    }
    internal class Serialization
    {
        static void Main(String[] args)
        {
            //Serializing Manager Object
            Manager1 manager = new Manager1();
            FileStream fileStream = new FileStream(@"c:\Serialization1.txt", FileMode.OpenorCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();

            //Serializing Employee Object
            Employee employee = new Employee();
            FileStream fileStream1 = new FileStream(@"c:\Serialization2.txt",FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fileStream, employee); 
            Console.ReadKey();

            //Serializing MarketingExecutive Object
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            FileStream fileStream2 = new FileStream(@"c:\Serialization3.txt", FileMode.Create);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(fileStream2, marketingExecutive);
            Console.ReadKey();

        }
    }
}
