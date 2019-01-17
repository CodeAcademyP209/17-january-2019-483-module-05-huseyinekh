using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUstomDelegate2
{
    public delegate bool NumberDelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {
                1,2,4,5,3,4,6,65,67,67,755
            };
            var customList = numbers.SerteGoreNEtice(x => x > 4);
            var secondCustomList = customList.SerteGoreNEtice(x => x % 2 == 0);
            foreach (var item in secondCustomList)
            {
                Console.WriteLine(item);
            }


            var maxList = numbers.MaxNetice(x => x*1 == x);
            foreach (var item in maxList)
            {
                
                    Console.WriteLine(  item);
                
            }

        }
    }
    public static class ExtentionMethod
    {
        public static List<int> SerteGoreNEtice(this List<int> list, NumberDelegate del)
        {
            var custom = new List<int>();
            foreach (var item in list)
            {
                if (del(item))
                {
                    custom.Add(item);
                }
            }return custom;
            
        }

        public static List<int> MaxNetice(this List <int> list,NumberDelegate del)
        {
            var maxValue = new List<int>();
            foreach (var item in list)
            {
                if (del(item))
                {
                    maxValue.Add(item);
                }
            }
            return maxValue;
        }




    }

}

