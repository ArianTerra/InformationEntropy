using System;
using EntropyLib;
using TextParser;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "Abakraba";
            string B = "Barbara tsucik";

            EntropyData ed1 = new EntropyData(A);
            EntropyData ed2 = new EntropyData(B);

            List<int> a = new List<int>();
            List<int> b = a;

        }
    }
}
