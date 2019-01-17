using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day10M
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numList = new List<int>()
            {
                1,2,56,3,67,45,789,12,34,87
            };
            void GreaterThenFIve()
            {
                List<int> numFiveList = new List<int>();
                foreach (var item in numList)

                {
                    Thread.Sleep(200);
                    if (item > 5)
                    {
                        Console.WriteLine(item);
                        numFiveList.Add(item);
                    }
                  
                }
                Console.WriteLine("-------");
            }

            GreaterThenFIve();
            void LessThanFourty()
            {
                List<int> numFourtyList = new List<int>();
                foreach (var item in numList)

                {
                    Thread.Sleep(200);
                    if (item <40 )
                    {
                        numFourtyList.Add(item);
                        Console.WriteLine(item);
                    }
                   
                }
                Console.WriteLine("-------");
            }
            LessThanFourty();
        }
    }
}
