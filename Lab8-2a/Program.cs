using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2a
{
    class Program
    {
        static void Main(string[] args)
               
        {
            string path = @"D:\new\new_file.txt";
            int[] t = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                t[i] = random.Next(-100, 101);
                Console.WriteLine("{0,4}", t[i]);
            }

            using (StreamWriter fs = new StreamWriter(path))
            {
                fs.WriteLine(string.Join(",", t.Select(i => i.ToString()).ToArray()));
            }
            string str;
            using (StreamReader sr = new StreamReader(path))
            {
                str = sr.ReadToEnd();
            }
            int s=str.Split(',').Select(c => int.Parse(c)).Sum();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
