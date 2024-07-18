using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace EuroMilhoesC_
{
    internal class Validation
    {
        /// <summary>
        /// Validation for .text to numbers
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="uniqueSet"></param>
        /// <param name="isValid"></param>
        /// <param name="errorMessages"></param>
        /// <returns>Return Valveif it's a number</returns>
        public int ValidateNumber(TextBox textBox, int minValue, int maxValue, HashSet<int> uniqueSet, ref bool isValid, List<string> errorMessages)
        {
            int value = int.Parse(textBox.Text);
            bool hasError = false;
            if (value < minValue || value > maxValue)
            {
                errorMessages.Add($"{textBox.ID} is out of range ({minValue}-{maxValue}).");
                hasError = true;
            }
            if (!uniqueSet.Add(value))
            {
                errorMessages.Add($"{textBox.ID} is a duplicate value.");
                hasError = true;
            }

            if (hasError)
            {
                textBox.CssClass += " error";
                isValid = false;
            }
            if (hasError)
            {
                textBox.CssClass = "input error-box";
                isValid = false;
            }
            else
            {
                textBox.CssClass = "input";
            }

            return value;
        }
        /// <summary>
        /// Validation for repeated Key
        /// </summary>
        /// <param name="keyList"></param>
        /// <param name="keyToCheck"></param>
        /// <returns>True if it's equal, False if it's different</returns>
        public bool RepeatedKeysValidation(List<Results> keyList, Results keyToCheck)
        {
            return keyList.Any(k => k.Numbers.SequenceEqual(keyToCheck.Numbers) && k.Stars.SequenceEqual(keyToCheck.Stars));
        }
    }
}
