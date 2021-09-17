using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyArray myArray = new MyArray(20, -10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.Divisibility3();
            Console.ReadLine();
        }

        public class MyArray
        {
            
            private int[] am;


            
            public MyArray(int n, int min, int max)
            {
                am = new int[n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                    am[i] = random.Next(min, max);
            }

            
            public int Divisibility3()
            {
                int count = 0;
                for (int i = 0; i < am.Length - 1; i++)
                {
                    if (am[i] % 3 == 0 || am[i + 1] % 3 == 0)
                        count++;
                    Console.WriteLine("Пара чисел: {0} и {1}", am[i], am[i + 1]);
                }
                Console.WriteLine("Количество пар: " + count);
                return count;
            }

            
            override public string ToString()
            {
                string stringarray = "";
                foreach (int x in am)
                    stringarray = stringarray + x + " ";
                return stringarray;
            }
        }
    }
}
