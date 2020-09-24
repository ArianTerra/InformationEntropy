using System;
using EntropyLib;
using TextParser;
namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            EntropyData data = new EntropyData(text, true);
            Console.WriteLine("Hartly: " + data.Hartly + " Shennon: " + data.Shennon);
            foreach (var key in data.Frequency)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }
        }
    }
}
