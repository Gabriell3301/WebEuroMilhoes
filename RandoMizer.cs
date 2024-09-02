using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWeb;

namespace EuroMilhoesC_
{
    internal class RandoMizer
    {
        Random random = new Random();
        public void CompleteWithRandomStars(List<int> list, int targetCount)
        {
            while (list.Count < targetCount)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(1, 13); // numbers between 1 and 12
                } while (list.Contains(randomNumber));
                list.Add(randomNumber);
            }
            list.Sort();
        }
        public void CompleteWithRandomNumbers(List<int> list, int targetCount)
        {
            
            while (list.Count < targetCount)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(1, 51); // numbers between 1 and 50
                } while (list.Contains(randomNumber));
                list.Add(randomNumber);
            }
            list.Sort();
        }
        public int GenerateWinner()
        {
            return random.Next(0, 3);
        }
        public long GenerateGain()
        {
            return random.Next(10000, 10000000);
        }

        /// <summary>
        /// Generate a Random results with random numbers
        /// </summary>
        /// <returns>Object Results</returns>
        public Results GenerateRandomKey()
        {
            List<int> number = new List<int>();
            List<int> star = new List<int>();
            CompleteWithRandomNumbers(number, 5);
            CompleteWithRandomStars(star, 2);
            Results key = new Results();
            key.NumberKey = GeneratetKeyNumber();
            key.Numbers = number;
            key.Stars = star;
            key.Winner = GenerateWinner();
            key.Gain = GenerateGain(); 
            return key;
        }

        /// <summary>
        /// Create a object Results from input User
        /// </summary>
        /// <param name="number">List</param>
        /// <param name="star">List</param>
        /// <returns>Complete Object Results</returns>
        public Results CreateUserKey(List<int> number, List<int> star)
        {
            Results key = new Results();
            key.NumberKey = GeneratetKeyNumber();
            key.Numbers = number;
            key.Stars = star;
            key.Winner = GenerateWinner();
            key.Gain = GenerateGain(); 
            return key;
        }
        /// <summary>
        /// Generate a key number from results count + 1
        /// </summary>
        /// <returns>Key number</returns>
        public int GeneratetKeyNumber()
        {
            if (Global.results.Count <= 0)
            {
                return 1;
            }
            else
            {
                return Global.results.Last().NumberKey + 1;
            }
        }
    }
}
