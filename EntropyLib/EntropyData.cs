﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EntropyLib
{
    
    public class EntropyData
    {
        public IEnumerable<KeyValuePair<char, double>> Frequency;
        public readonly double Shennon, Hartly;

        public EntropyData(string text, bool onlyLetters = true, bool ignoreSpaces = true)
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

            this.Frequency = dictionary;
            this.Hartly = hartly;
            this.Shennon = shennon;
        }
    }
}