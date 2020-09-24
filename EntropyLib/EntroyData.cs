using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyLib
{
    public class EntroyData
    {
        public IEnumerable<KeyValuePair<char, double>> Frequency;
        public double Shennon = 0, Hartly = 0;

        private EntroyData(IEnumerable<KeyValuePair<char, double>> frequency, double shennon, double hartly)
        {
            Frequency = frequency;
            Shennon = shennon;
            Hartly = hartly;
        }
        public static EntroyData GetData(string text, bool onlyLetters)
        {
            int count;
            string temptext = string.Empty;
            // Подсчитать количество всех символов
            if (onlyLetters)
            {
                count = text.Count(x => char.IsLetter(x));
                foreach (char ch in text)
                {
                    if (char.IsLetter(ch)) temptext += ch.ToString();
                }
            }
            else
            {
                count = text.Length;
                temptext = text;
            }
            // Получить пары символ-частота
            SortedDictionary<char, double> dictionary = new SortedDictionary<char, double>();
            foreach (char ch in temptext)
            {
                if (dictionary.ContainsKey(ch))
                    dictionary[ch]++;
                else
                    dictionary.Add(ch, 1);
            }
            foreach (var key in dictionary.Keys.ToArray())
            {
                dictionary[key] /= Convert.ToDouble(count);
            }
            // Расчет по формуле Шеннона
            double shennon = -dictionary.Count * dictionary.Values.Aggregate((s, x) => s + x * Math.Log(x));
            // Расчет по формуле Хартли
            double hartly = Math.Log(dictionary.Keys.Count);

            return new EntroyData(dictionary, shennon, hartly);
        }
    }
}