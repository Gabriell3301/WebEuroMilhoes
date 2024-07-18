using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace WebWeb
{
    public partial class Amount_Keys : System.Web.UI.Page
    {
        private static List<Results> generatedKeys = new List<Results>();
        private static List<Results> allKeys = new List<Results>();
        /// <summary>
        /// Clear Label
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_Error.Visible = false;
        }
        /// <summary>
        /// Clicking on the button generates a number of keys
        /// </summary>
        protected void GenerateKeys(object sender, EventArgs e)
        {
            int numberOfKeys;
            allKeys = Global.results;
            if (int.TryParse(NumberOfKeys.Text, out numberOfKeys) && numberOfKeys > 0)
            {
                Validation validation = new Validation();
                RandoMizer rando = new RandoMizer();
                generatedKeys.Clear(); // Limpa a lista de chaves geradas
                int a = rando.GeneratetKeyNumber();
                for (int i = 0; i < numberOfKeys; i++)
                {
                    Results key;
                    do
                    {
                        key = rando.GenerateRandomKey();
                        key.NumberKey = a;
                    }
                    while (validation.RepeatedKeysValidation(allKeys, key));
                    allKeys.Add(key);
                    generatedKeys.Add(key);
                    a++;
                }

                DisplayKeys();
            }
            else
            {
                Label_Error.Text = "Please enter a valid number of keys.";
                Label_Error.Visible = true;
            }
        }

        /// <summary>
        /// Only for Show key in the screen
        /// </summary>
        private void DisplayKeys()
        {
            placeHolderKeys.Controls.Clear(); // Limpa o conteúdo do placeholder
            foreach (var key in generatedKeys)
            {
                Label keyLabel = new Label();
                keyLabel.CssClass = "key";
                keyLabel.Text = $"Number Key: {key.NumberKey} Stars: {string.Join(",", key.Stars)} Numbers: {string.Join(",", key.Numbers)}<br />";

                placeHolderKeys.Controls.Add(keyLabel);
            }

            Label_Error.Visible = false;
        }
        /// <summary>
        /// By clicking on the button, it passes the try and writes to the list results and writes to the database
        /// </summary>
        protected void SaveKeys(object sender, EventArgs e)
        {
            List<bool> Sucsses = new List<bool>();
            List<int> erroList = new List<int>();
            Validation validation = new Validation();
            try
            {
                foreach (var key in generatedKeys)
                {
                    Global.results.Add(key);
                    Sucsses.Add(DataBase.SaveLastResultInDataBase());
                    if (Sucsses.Last() == false)
                    {
                        erroList.Add(key.NumberKey);
                    }
                }
                if (Sucsses.Any(b => b != false))
                {
                    if (Sucsses.Count()!= generatedKeys.Count)
                    {
                        DataBase.MenssageSave(Label_Error, false, erroList);

                    }
                    DataBase.MenssageSave(Label_Error, true, erroList);                    
                }
                else
                {
                    DataBase.MenssageSave(Label_Error, false, erroList);
                }
                generatedKeys.Clear();
            }
            catch (Exception)
            {
                Label_Error.Text = "An error occurred while saving the keys. Please try again.";
                Label_Error.Visible = true;
            }
        }
    }
}