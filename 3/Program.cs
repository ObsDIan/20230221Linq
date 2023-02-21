using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            foreach (var item in Enumerable.Range(1, n).ToList())
            {
                Console.WriteLine(string.Join("", Enumerable.Repeat((n + 1) - item, item).ToList()));
            }
            Console.ReadLine();
        }
    }
}
