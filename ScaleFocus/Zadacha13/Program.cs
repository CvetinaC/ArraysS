using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int b = 6;
            int min=0;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < A.Length; i++)
            {
                min = A[i];
                if (A[i] < min && A[i] > b)
                {
                    min = A[i];
                }
            }
            Console.WriteLine("The element with min value, which is bigger than b is  : " + min);
        }
    }
}
