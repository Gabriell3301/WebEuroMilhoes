using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWeb;

namespace EuroMilhoesC_
{
    internal class Analyse
    {
        //public void FrequencyNumber()
        //{
        //    Validation validation = new Validation();
        //    Console.WriteLine("Write a number to Analyze: ");

        //    int frequencyNumber = Global.results.SelectMany(c => c.Numbers).Count(n => n == numberAlalyze);

        //    Console.WriteLine($"Nº {numberAlalyze} saiu {frequencyNumber} vezes em {Global.results.Count} extrações, ({(double)frequencyNumber / (Global.results.Count) * 100:F2}%)");
        //}


        /// <summary>
        /// Return the top 5 numbers that appear the most
        /// </summary>
        /// <returns></returns>
        public List<String> TopFiveNumbers()
        {
            List<String> top5 = new List<String>();
            var frequencias = Global.results.SelectMany(c => c.Numbers).GroupBy(n => n).Select(g => new { Numero = g.Key, Frequency = g.Count() }).OrderByDescending(x => x.Frequency).Take(5);

            Console.WriteLine("Top 5 numbers most spawns:");
            foreach (var freq in frequencias)
            {
                top5.Add($"Nº {freq.Numero} came out {freq.Frequency} times in {Global.results.Count} extractions, ({(double)freq.Frequency / (Global.results.Count) * 100:F2}%)");
            }
            return top5;
        }
        public String LastKey()
        {
            Results a = Global.results.Last();
            return ($"Number Key: {a.NumberKey}<br/>Stars: {string.Join(", ", a.Stars)}<br/>Numbers: {string.Join(", ", a.Numbers)}<br/>Date: {a.Date}<br/>Winner: {a.Winner}");
        }
    }
}
