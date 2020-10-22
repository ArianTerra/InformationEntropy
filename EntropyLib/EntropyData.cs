using System;
using System.Collections.Generic;
using System.Linq;

namespace EntropyLib
{
    public class EntropyData
    {
        public List<KeyValuePair<char, double>> Frequency;
        public readonly double Shennon, Hartly,
            Entropy, MaximumEntropy,
            Compression, Redundancy;
        public readonly string Temptext;

        public EntropyData(string text, bool onlyLetters = true, bool ignoreSpaces = true)
        {
            string temptext = string.Empty;
            // Подсчитать количество всех символов.
            if (onlyLetters)
            {
                foreach (char ch in text)
                {
                    if (char.IsLetter(ch)) temptext += ch.ToString();
                }
            }
            else
            {
                temptext = text;
            }
            //Удалить пустые символы если необходимо.
            if (ignoreSpaces)
            {
                temptext = string.Concat(temptext.Where(c => !char.IsWhiteSpace(c)));
            }
            this.Temptext = temptext;
            // Получить пары символ-частота.
            SortedDictionary<char, double> dictionary = new SortedDictionary<char, double>();
            foreach (char ch in Temptext)
            {
                if (dictionary.ContainsKey(ch))
                    dictionary[ch]++;
                else
                    dictionary.Add(ch, 1);
            }
            // Расчет максимальной энтропии.
            double maximumEntropy = Math.Log(dictionary.Count, 2);
            // Расчет по формуле Хартли.
            double hartly = Temptext.Length * maximumEntropy;

            foreach (var key in dictionary.Keys.ToArray())
            {
                dictionary[key] /= Convert.ToDouble(Temptext.Length);
            }
            // Расчет энтропии.
            double entropy = -dictionary.Values.Aggregate(0.0, (s, x) => s + x * Math.Log(x, 2));
            // Расчет по формуле Шеннона.
            double shennon = Temptext.Length * entropy;

            this.Frequency = dictionary.OrderByDescending(x => x.Value).ToList();
            this.Hartly = hartly;
            this.Shennon = shennon;
            this.Entropy = entropy;
            this.MaximumEntropy = maximumEntropy;
            this.Compression = this.Entropy / this.MaximumEntropy;
            this.Redundancy = 1.0 - Compression;
        }
    }

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

        // Конвертировать в необходиымй формат.
        private static List<Symbol> EntropyDataToSymbols(EntropyData ed) => 
            ed.Frequency.Select(t => new Symbol(t.Key, t.Value)).ToList();

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

    public class EntropyDataCombined
    {
        public readonly double EntropyA, EntropyB,
            EntropyCombinedIndependent,
            EntropyCombinedAB, EntropyCombinedBA;

        public List<double> Alphabet, Blaphabet;
        public List<List<double>> AlpDepBlap;
        public List<List<double>> BlapDepAlp; 

        public EntropyDataCombined()
        {
            // Временные переменные.
            Random Ran = new Random();
            int total;
            int[] Back = new int[M];
            int[] Pack = new int[M];
            double[] Alp = new double[M];
            double[] Blp = new double[M];

            // Подбор вероятностей для первого алфавита.
            for (int i = 0; i < M; i++)
            {
                Back[i] = Ran.Next(1, 10);
            }
            total = Back.Aggregate(0, (s, x) => s + x);
            for (int i = 0; i < M; i++)
            {
                Alp[i] = (double)Back[i] / total;
            }
            Alphabet = Alp.Select(x => x).ToList();

                // Подбор вероятностей для второго алфавита.
                for (int i = 0; i < M; i++)
                {
                    Pack[i] = Ran.Next(1, 10);
                }
                total = Back.Aggregate(0, (s, x) => s + x);
                for (int i = 0; i < M; i++)
                {
                    Blp[i] = (double)Pack[i] / total;
                }
                Blaphabet = Blp.Select(x => x).ToList();

            // Генерация зависимых событий.
            List<List<double>> avs = new List<List<double>>(M);
            for (int i = 0; i < M; i++)
            {
                avs.Add(new List<double>(M));
                for (int j = 0; j < M; j++)
                {
                    avs[i].Add(Ran.NextDouble());
                }
            }
            AlpDepBlap = avs.Select(x => x.Select(n => n).ToList()).ToList();

                List<List<double>> bvs = new List<List<double>>(M);
                for (int i = 0; i < M; i++)
                {
                    bvs.Add(new List<double>(M));
                    for (int j = 0; j < M; j++)
                    {
                        bvs[i].Add(Ran.NextDouble());
                    }
                }
                BlapDepAlp = bvs.Select(x => x.Select(n => n).ToList()).ToList();

            // Расчет энтропий.
            EntropyCombinedIndependent = (EntropyA = -Alphabet.Aggregate(0.0, (s, x) => s + x * Math.Log(x, 2))) +
                (EntropyB = -Blaphabet.Aggregate(0.0, (s, x) => s + x * Math.Log(x, 2)));

            EntropyCombinedAB = 0.0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    EntropyCombinedAB += Alp[i] * Alp[i] * avs[i][j] * Math.Log(avs[i][j], 2);
                }
            }
            EntropyCombinedAB = -EntropyCombinedAB;

            EntropyCombinedBA = 0.0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    EntropyCombinedBA += Blp[i] * Blp[i] * bvs[i][j] * Math.Log(bvs[i][j], 2);
                }
            }
            EntropyCombinedBA = -EntropyCombinedBA;
        }

        const int M = 10;
    }
}

