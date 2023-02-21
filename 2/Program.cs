using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("輸入數字");
            //string input = Console.ReadLine();

            string input = "8,7,9,3,11,6,2,18";

            List<string> list = new List<string>();
       
            input.Split(',').ToList().ForEach(list.Add);
            list = list.OrderBy((x) => int.Parse(x)).ToList();

            var output1 = list.Where((x) => int.Parse(x) % 2 == 0);
            var output2 = list.Where((x) => int.Parse(x) % 2 != 0);

            Console.WriteLine($"輸入 {input}");
            Console.WriteLine($"奇數 {string.Join(",", output2)}");
            Console.WriteLine($"偶數 {string.Join(",", output1)}");
            


            Console.ReadKey();


        }
    }
}
