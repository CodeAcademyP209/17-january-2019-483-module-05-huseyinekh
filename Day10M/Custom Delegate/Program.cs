using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Delegate
{
public delegate bool NumberDelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {
                1,2,4,5,3,4,6,65,67,67,755
            };

            void FirsMethod(NumberDelegate del)
            {
               
                foreach (var item in numbers)
                {
                    if (del(item))
                    {
                        Console.WriteLine(item);
                    }
                }

                
            }
            FirsMethod(x => x > 5);

        }
        
    }
}
