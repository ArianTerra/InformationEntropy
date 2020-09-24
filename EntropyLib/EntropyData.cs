using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntropyLib
{
    
    public class EntropyData
    {
        public IEnumerable<KeyValuePair<char, double>> Frequency;
        public double Shennon = 0, Hartly = 0;

        private EntropyData(IEnumerable<KeyValuePair<char, double>> frequency, double shennon, double hartly)
        {
            Frequency = frequency;
            Shennon = shennon;
            Hartly = hartly;
        }
        public static EntropyData GetData(string text, bool onlyLetters = true, bool ignoreSpaces = true)
        {
            string temptext = string.Empty;
            // Подсчитать количество всех символов
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
            //Удалить пустые символы если необходимо
            if (ignoreSpaces)
            {
                temptext = string.Concat(temptext.Where(c => !char.IsWhiteSpace(c)));
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
                dictionary[key] /= Convert.ToDouble(temptext.Length);
            }
            // Расчет по формуле Шеннона
            double shennon = -dictionary.Count * dictionary.Values.Aggregate((s, x) => s + x * Math.Log(x));
            // Расчет по формуле Хартли
            double hartly = Math.Log(dictionary.Keys.Count);

            return new EntropyData(dictionary, shennon, hartly);
        }
    }
}