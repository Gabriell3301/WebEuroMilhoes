using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWeb
{
    public partial class Complete_Keys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GenerateKey(object sender, EventArgs e)
        {
            RandoMizer rand = new RandoMizer();
            List<int> numbers = new List<int>();
            List<int> stars = new List<int>();

            // Collect user input
            CollectUserInput(txtNumber1, numbers);
            CollectUserInput(txtNumber2, numbers);
            CollectUserInput(txtNumber3, numbers);
            CollectUserInput(txtNumber4, numbers);
            CollectUserInput(txtNumber5, numbers);

            // Complete with random numbers if necessary
            rand.CompleteWithRandomNumbers(numbers, 5);
            rand.CompleteWithRandomStars(stars, 2);
            Validation validation = new Validation();
            Results key = rand.CreateUserKey(numbers, stars);
            if (!validation.RepeatedKeysValidation(Global.results, key))
            {
                Global.results.Add(key);
                bool Sucsses = DataBase.SaveLastResultInDataBase();
                DataBase.MenssageSave(Label, Sucsses, null);
            }
            else
            {
                DataBase.MenssageSave(Label, false, null);
            }

            // Display the result
            DisplayResult(numbers, stars);
        }

        private void CollectUserInput(TextBox textBox, List<int> list)
        {
            if (int.TryParse(textBox.Text, out int value))
            {
                list.Add(value);
            }
        }

        private void DisplayResult(List<int> numbers, List<int> stars)
        {
            result.Visible = true;
            result.InnerHtml = $"<strong>Generated Key:</strong><br />" +
                $"Stars: {string.Join(", ", stars)} " +
                $"Numbers: {string.Join(", ", numbers)}<br />";
        }
    }
}