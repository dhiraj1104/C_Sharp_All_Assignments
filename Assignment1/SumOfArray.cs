using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        public static int sum_of_arrays(int[] arr1)
        {
            int total = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                total+= arr1[i];
            }
            return total;

        }
        static void Main(string[] args)
        {

            int[] arr1=new int[5];
            Console.WriteLine("\n function calculates the sum of elements in an array:");
            Console.WriteLine("\n it takes input of 5 elememts in an array:");
            for(int j=0; j < 5 ; j++)
            {
                Console.Write("Element-{0}:", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is {0}:", sum_of_arrays(arr1));
          
        }
    }
}