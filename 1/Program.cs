using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("輸入字串(ex.12,18,13,23,32)");
            //string input = Console.ReadLine();
            string input = "12,18,13,23,32";

            Console.WriteLine($"輸入 {input}");
            Console.WriteLine($"結果 {string.Join(",", input.Split(',').Reverse())}");

            Console.ReadLine();

        }
    }
}
