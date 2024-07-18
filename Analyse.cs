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
        public void FrequencyNumber()
        {
            Validation validation = new Validation();
            Console.WriteLine("Write a number to Analyze: ");
            int numberAlalyze = validation.ConverserStringtoInt();

            int frequencyNumber = Global.results.SelectMany(c => c.Numbers).Count(n => n == numberAlalyze);

            Console.WriteLine($"Nº {numberAlalyze} saiu {frequencyNumber} vezes em {Global.results.Count} extrações, ({(double)frequencyNumber / (Global.results.Count) * 100:F2}%)");
        }
        public void TopFiveNumbers()
        {
            var frequencias = Global.results.SelectMany(c => c.Numbers).GroupBy(n => n).Select(g => new { Numero = g.Key, Frequency = g.Count() }).OrderByDescending(x => x.Frequency).Take(5);

            Console.WriteLine("Top 5 numbers most spawns:");
            foreach (var freq in frequencias)
            {
                Console.WriteLine($"Nº {freq.Numero} came out {freq.Frequency} times in {Global.results.Count} extractions, ({(double)freq.Frequency / (Global.results.Count) * 100:F2}%)");
            }
        }
    }
}
