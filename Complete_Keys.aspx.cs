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
            txtNumber1.CssClass = "input-field";
            txtNumber2.CssClass = "input-field";
            txtNumber3.CssClass = "input-field";
            txtNumber4.CssClass = "input-field";
            txtNumber5.CssClass = "input-field";
            Label.Text = "";
            Label.Visible = false;
            Label.ForeColor = System.Drawing.Color.White;
            result.Visible = false;
        }
        protected void GenerateKey(object sender, EventArgs e)
        {
            RandoMizer rand = new RandoMizer();
            List<int> numbers = new List<int>();
            List<int> stars = new List<int>();
            bool error = false;

            try
            {
                // Collect user input numbers
                CollectUserInput(txtNumber1, numbers, ref error);
                CollectUserInput(txtNumber2, numbers, ref error);
                CollectUserInput(txtNumber3, numbers, ref error);
                CollectUserInput(txtNumber4, numbers, ref error);
                CollectUserInput(txtNumber5, numbers, ref error);

                if (error)
                {
                    throw new Exception();
                }

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
            catch (Exception)
            {
                Label.Text = "Write a diferrent number or write a number beetwen (1-50)";
                Label.Visible = true;
                Label.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void CollectUserInput(TextBox textBox, List<int> list, ref bool error)
        {
            if (int.TryParse(textBox.Text, out int value))
            {
                if (list.Contains(value) || value < 1 || value > 50)
                {
                    textBox.CssClass += " error-field";
                    error = true;
                }
                else
                {
                    list.Add(value);
                }
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