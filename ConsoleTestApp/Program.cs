using System;
using EntropyLib;
using TextParser;
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

        }
    }
}
