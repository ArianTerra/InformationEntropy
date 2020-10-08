using System;
using System.Collections.Generic;
using System.Linq;

namespace EntropyLib
{
    public class EntropyData
    {
        public IEnumerable<KeyValuePair<char, double>> Frequency;
        public readonly double Shennon, Hartly,
            Entropy, MaximumEntropy,
            Compression, Redundancy;
        private readonly string Temptext;

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

    public class EntropyDataCombined
    {
        public readonly double EntropyA, EntropyB,
            EntropyCombinedIndependent,
            EntropyCombinedAB, EntropyCombinedBA;

        public IEnumerable<double> Alphabet, Blaphabet;
        public IEnumerable<IEnumerable<double>> AlpDepBlap;
        public IEnumerable<IEnumerable<double>> BlapDepAlp; 

        // Генерируем случайные вероятности появления символов для Alphabet и Blaphabet.
        // После создаем случайные зависимости между ними с AlpDepBlap и BlapDepAlp.
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
            Alphabet = Alp.Select(x => x);

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
                Blaphabet = Blp.Select(x => x);

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
            AlpDepBlap = avs.Select(x => x.Select(n => n));

                List<List<double>> bvs = new List<List<double>>(M);
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        bvs[i].Add(Ran.NextDouble());
                    }
                }
                BlapDepAlp = bvs.Select(x => x.Select(n => n));

            // Расчет энтропий.
            EntropyCombinedIndependent = (EntropyA = Alphabet.Aggregate(0.0, (s, x) => s + x * Math.Log(x, 2))) *
                (EntropyB = Blaphabet.Aggregate(0.0, (s, x) => s + x * Math.Log(x, 2)));

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