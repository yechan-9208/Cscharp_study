using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practice_03
{
    internal class StringSlice
    {
        static void Main(string[] args)
        {
            string greeting = "good moring.";

            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));

            string[] arr = greeting.Split(
                new string[] {" "},StringSplitOptions.None);
            WriteLine($"word count : {arr.Length}");

            foreach (string element in arr)
                WriteLine("{0}", element);
            
        }
    }
}
