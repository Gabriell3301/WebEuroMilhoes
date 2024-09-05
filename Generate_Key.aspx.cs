using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWeb
{
    public partial class Generate_Key : System.Web.UI.Page
    {
        private static Results key = new Results();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                key = new Results();
            }
            Label_Error1.Text= string.Empty;
            Label_Error1.Visible=false;
        }
        /// <summary>
        /// This is a Button for Generate Random Key
        /// </summary>
        protected void GenereateKey(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            RandoMizer rando = new RandoMizer();
            key = rando.GenerateRandomKey();
            do
            {
                key = rando.GenerateRandomKey();
            }
            while (validation.RepeatedKeysValidation(Global.results, key));
            Label_Key.Text = $"Number Key: {key.NumberKey} Stars: {string.Join(",", key.Stars)} Number: {string.Join(",", key.Numbers)}";
            Label_Key.Visible = true;
        }
        /// <summary>
        /// Save Results in Data Base and save in List Results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SaveKeys(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            try
            {
                if (!(validation.RepeatedKeysValidation(Global.results, key)))
                {
                    Global.results.Add(key);
                    bool Sucsses = DataBase.SaveLastResultInDataBase();
                    DataBase.MenssageSave(Label_Error1, Sucsses, null);
                }
                else
                {
                    Label_Error1.Text = "That key already exists. Generate another key";
                    Label_Error1.ForeColor = System.Drawing.Color.Red;
                    Label_Error1.Visible = true;
                }
            }
            catch (Exception a)
            {
                Label_Error1.Text = $"Something went wrong<br/>Error: {"Unable to Save this key"}";
                Label_Error1.ForeColor = System.Drawing.Color.Red;
                Label_Error1.Visible = true;
            }
        }
    }
}