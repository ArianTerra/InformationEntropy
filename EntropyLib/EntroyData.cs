using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyLib
{
    public class EntroyData
    {
        public List<KeyValuePair<char, double>> Frequency;
        public double Shennon = 0, Hartly = 0;

        public static EntroyData GetInfo(string text)
        {
            // Подсчитать количество всех символов
            int cn = text.Count(x => char.IsLetter(x));
            int shft = 0;
            char[] st = new char[cn];
            // Получить строку состоящую исключительно из символов алфавита
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                    st[shft++] = ch;
            }
            // Получить пары символ-частота
            SortedDictionary<char, double> besort = new SortedDictionary<char, double>();
            foreach (char ch in st)
            {
                if (besort.ContainsKey(ch))
                    besort[ch]++;
                else
                    besort.Add(ch, 1);
            }
            char[] l = besort.Keys.ToArray();
            foreach (var key in l)
            {
                besort[key] /= Convert.ToDouble(cn);
            }
            // Расчет по формуле Шеннона
            double Shennon = -besort.Count * besort.Values.Aggregate((s, x) => s + x * Math.Log(x));
            // Расчет по формуле Хартли
            double Hartly = Math.Log(besort.Keys.Count);

            EntroyData dat = new EntroyData();
            dat.Frequency = besort.ToList();
            dat.Shennon = Shennon;
            dat.Hartly = Hartly;

            return dat;
        }
    }
}