﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EntropyLib
{
    [Serializable]
    public class Symbol
    {
        char name;
        string code;
        double probability;

        public static List<Symbol> symbols;
        public static Dictionary<char, string> map;

        public Symbol(char name, double probability)
        {
            this.name = name;
            this.probability = probability;
            this.code = "";
        }

        // Расчитать скорость передачи данных
        public static double Rspeed(EntropyData ed)
        {
            double t = 0.0;
            Random r = new Random();
            foreach (var Fr in ed.Frequency)
            {
                t += ((0.001 + r.NextDouble() % 0.001) * Fr.Value) * 1000000;
            }                  
            return ed.Entropy / t;
        }

        // Конвертировать в необходиымй формат.
        private static List<Symbol> EntropyDataToSymbols(EntropyData ed) => 
            ed.Frequency.Select(t => new Symbol(t.Key, t.Value)).ToList();

        // Среднее количество кодовых символов приходящихся на один символ сообщения.
        public static double MeanCodePerSymbol() => 
            symbols.Aggregate(0.0, (s, x) => s + x.probability * x.CodeLength);

        // Определение степени близости.
        public static double HowNear(EntropyData ed) => (MeanCodePerSymbol() / ed.Entropy) - 1.0;

        // Найти коды.
        public static void FigureEncoding(EntropyData ed)
        {
            symbols = EntropyDataToSymbols(ed);
            symbols = symbols.OrderByDescending(s => s.Probability).ToList();
            symbols = CalculateSymbolsCodes(symbols);

            map = new Dictionary<char, string>();
            symbols.ForEach(sym => map.Add(sym.Name, sym.Code));
        }

        // Применить алгоритм.
        public static string ApplyEncoding(string text)
        {
            string res = string.Empty;
            foreach (char c in text)
                res += map[c];
            return res;
        }

        // Декодировать штуку.
        public static string ApplyDecoding(string text)
        {
            var maper = symbols.OrderBy(s => s.Code).ToList();
            int carry = 0;
            Symbol thisCode = null;
            string result = string.Empty;
            while (carry < text.Length)
            {
                foreach (var m in maper)
                {
                    if (text.Substring(carry).StartsWith(m.Code))
                    {
                        thisCode = m;
                        break;
                    }
                }
                result += thisCode.Name;
                carry += thisCode.CodeLength;
            }
            return result;
        }

        // Непосредственно находит коды.
        private static List<Symbol> CalculateSymbolsCodes(List<Symbol> symbols)
        {
            var separationPoint = GetSeparationIndex(symbols) + 1;

            var firstList = symbols.GetRange(0, separationPoint);
            var secondList = symbols.GetRange(separationPoint, symbols.Count - separationPoint);

            firstList.ForEach(symbol => symbol.Code += "0");
            if (firstList.Count > 1) CalculateSymbolsCodes(firstList);

            secondList.ForEach(symbol => symbol.Code += "1");
            if (secondList.Count > 1) CalculateSymbolsCodes(secondList);

            firstList.AddRange(secondList);

            return firstList;
        }

        // Находит разбиение при котором значения будут максимально близки к половине.
        private static int GetSeparationIndex(List<Symbol> symbols)
        {
            var differences = new List<Tuple<double, int>>();
            var half = symbols.Sum(s => s.Probability) / 2;
            var sum = 0.0;
            for (var i = 0; i < symbols.Count; i++)
            {
                sum += symbols[i].Probability;
                var diff = Math.Abs(half - sum);
                differences.Add(Tuple.Create(diff, i));
            }
            differences.Sort();
            return differences[0].Item2;
        }
        
        public char Name { get => name; }
        public double Probability { get => probability; }
        public string Code { get => code; set => code = value; }
        public int CodeLength { get => code.Length; }
    }
}