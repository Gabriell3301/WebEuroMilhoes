using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroMilhoesC_
{
    internal class Results
    {
        public DateTime Date { get; set; }
        public List<int> Numbers { get; set; }
        public List<int> Stars { get; set; }
        public int Winner { get; set; }
        public long Gain { get; set; }
        public int NumberKey { get; set; }
        public Results()
        {
            Date = DateTime.Now;
        }
    }
}
