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
}

