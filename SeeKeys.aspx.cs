using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWeb
{
    public partial class SeeKeys : System.Web.UI.Page
    {
        /// <summary>
        /// Show all keys existents
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var key in Global.results)
                {
                    Label keyLabel = new Label();
                    keyLabel.CssClass = "key";
                    keyLabel.Text = $"Number Key: {key.NumberKey} Stars: {string.Join(",", key.Stars)} Numbers: {string.Join(",", key.Numbers)}<br />";
                    placeHolderKeys.Controls.Add(keyLabel);
                }
                Label_Error.Visible = false; // Esconde a mensagem de erro se as chaves forem salvas com sucesso
            }
            catch (Exception a)
            {
                Label_Error.Text = $"An error occurred while show the keys. Please try again {a}.";
                Label_Error.Visible = true;
            }
        }
    }
}