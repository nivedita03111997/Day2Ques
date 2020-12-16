using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMaxPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 10;
            bool flag = false;
            int max = 40;
            for(int i = min; i <= max; i++)
            {
                flag = false;
                for(int j = 2;j < i/2;j++)
                {
                    if(i%j==0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Nidhi Kumari");
                    Console.ReadKey();
                }
            }
        }
    }
}
