using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class MyArrayList
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalaray { get; set; }
    }

    internal class ArrayListAssignment
    {

        public static void Main(String[] args)
        {
            ArrayList employees = new ArrayList()
        {
            new MyArrayList { EmployeeId = 10, EmployeeName = "Ram" , EmployeeSalaray = 20000 },
            new MyArrayList { EmployeeId = 11, EmployeeName = "Sham" , EmployeeSalaray = 15000 },
            new MyArrayList { EmployeeId = 12, EmployeeName = "Dyanesh" , EmployeeSalaray = 30000 },
            new MyArrayList { EmployeeId = 13, EmployeeName = "Nagesh" , EmployeeSalaray = 25000 }
        };

            foreach (MyArrayList employee in employees)
            {
                Console.WriteLine(employee.EmployeeId + " " + employee.EmployeeName + " " + employee.EmployeeSalaray);
            }

            Console.ReadKey();
        }

    }
}