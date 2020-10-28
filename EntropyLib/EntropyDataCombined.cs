using System;
using System.Collections.Generic;
using System.Linq;

namespace EntropyLib
{
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