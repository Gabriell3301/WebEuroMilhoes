using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWeb
{
    public partial class Create_Keys : System.Web.UI.Page
    {
        /// <summary>
        /// Clear Label Erro
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_Error1.Visible = false;
            Label_Error1.ForeColor=System.Drawing.Color.Red;
            Label_Error1.Text = string.Empty;
            Label_Error2.Visible = false;
            Label_Error2.ForeColor = System.Drawing.Color.Red;
            Label_Error2.Text = string.Empty;
        }
        /// <summary>
        /// Create a User Key
        /// </summary>
        protected void SendKeyUser(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            RandoMizer rando = new RandoMizer();
            List <int> stars = new List<int>();
            List <int> numbers = new List<int>();
            List<string> errorMessages = new List<string>();
            HashSet<int> uniqueStars = new HashSet<int>();
            HashSet<int> uniqueNumber = new HashSet<int>();
            Results key = new Results();
            bool isValid = true;
            try
            {
                stars.Add(validation.ValidateNumber(Estrela1, 1, 12, uniqueStars,ref isValid, errorMessages));
                stars.Add(validation.ValidateNumber(Estrela2, 1, 12, uniqueStars,ref isValid, errorMessages));
                numbers.Add(validation.ValidateNumber(Numero1, 1, 50, uniqueNumber,ref isValid, errorMessages));
                numbers.Add(validation.ValidateNumber(Numero2, 1, 50, uniqueNumber,ref isValid, errorMessages));
                numbers.Add(validation.ValidateNumber(Numero3, 1, 50, uniqueNumber,ref isValid, errorMessages));
                numbers.Add(validation.ValidateNumber(Numero4, 1, 50, uniqueNumber,ref isValid, errorMessages));
                numbers.Add(validation.ValidateNumber(Numero5, 1, 50, uniqueNumber,ref isValid, errorMessages));
                stars.Sort();
                numbers.Sort();
                if (!(isValid))
                {
                    Label_Error2.Text = string.Join("<br/>", errorMessages);
                    Label_Error2.Visible = true;
                }
                else
                {
                    key = rando.CreateUserKey(numbers, stars);
                    if (!(validation.RepeatedKeysValidation(Global.results, key)))
                    {
                        Global.results.Add(key);
                        bool Sucsses = DataBase.SaveLastResultInDataBase();
                        DataBase.MenssageSave(Label_Error1, Sucsses, null);
                        DisplayResult(key.Numbers, key.Stars);
                    }
                    else
                    {
                        Label_Error1.Text = "Repeated. Insert a Different number";
                        Label_Error1.Visible = true;
                    }
                }
                
            }
            catch (Exception a)
            {
                Label_Error1.Text = "Something went wrong";
                Label_Error1.Visible = true;
                Label_Error2.Text = "Error: " + a.Message;
                Label_Error2.Visible = true;
            }
        }
        private void DisplayResult(List<int> numbers, List<int> stars)
        {
            result.Visible = true;
            result.InnerHtml = $"<strong>Your Key:</strong><br />" +
                $"Stars: {string.Join(", ", stars)} " +
                $"Numbers: {string.Join(", ", numbers)}<br />";
        }
    }
}