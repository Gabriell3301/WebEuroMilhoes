using EuroMilhoesC_;
using Microsoft.EntityFrameworkCore.Metadata;
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
                    keyLabel.Text = $"Number Key: {key.NumberKey} Stars: {string.Join(",", key.Stars)} Numbers: {string.Join(",", key.Numbers)} Date: {key.Date}<br />";
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
        protected void BtnSearch_click(object seder, EventArgs e)
        {
            int searchKey = 0;
            int intervalo1 = 0;
            int intervalo2 = 0;
            bool intervalos = false;
            string[] intervalo;
            intervalo = BuscarKey.Text.Split('-');
            if (int.TryParse(BuscarKey.Text, out int a))
            {
                searchKey = a;
            }
            else
            {
                if (int.TryParse(intervalo[0], out int c))
                {
                    intervalo1 = c;
                    if (int.TryParse(intervalo[1], out int b))
                    {
                        intervalo2 = b;
                        intervalos = true;
                    }else
                    {
                        intervalo2 = intervalo1;
                    }
                }else
                {
                    intervalo1 = 0;
                }
            }
            List<Results> filteredResults;
            placeHolderKeys.Controls.Clear();
            if (intervalos)
            {
                if (intervalo1 < intervalo2)
                {

                    filteredResults = Global.results
                     .Where(x => x.NumberKey >= intervalo1 || x.NumberKey <= intervalo2)
                     .ToList();
                }
                else
                {
                    filteredResults = Global.results
                     .Where(x => x.NumberKey >= intervalo2 || x.NumberKey <= intervalo1)
                     .ToList();
                }
            }
            else { 
                filteredResults = Global.results.Where(x => x.NumberKey == searchKey).ToList();            
            }

            foreach (var key in filteredResults)
            {
                Label keyLabel = new Label
                {
                    CssClass = "key",
                    Text = $"Number Key: {key.NumberKey} Stars: {string.Join(", ", key.Stars)} Numbers: {string.Join(", ", key.Numbers)} Date: {key.Date}<br />"
                };

                placeHolderKeys.Controls.Add(keyLabel);
            }
            if (BuscarKey.Text == "")
            {
                foreach (var key in Global.results)
                {
                    Label keyLabel = new Label
                    {
                        CssClass = "key",
                        Text = $"Number Key: {key.NumberKey} Stars: {string.Join(", ", key.Stars)} Numbers: {string.Join(", ", key.Numbers)} Date: {key.Date}<br />"
                    };

                    placeHolderKeys.Controls.Add(keyLabel);
                }
            }
        }
        protected void sortByDate(string direction)
        {
            var sortedResults = (direction == "asc")
                ? Global.results.OrderBy(x => x.Date).ToList()
                : Global.results.OrderByDescending(x => x.Date).ToList();

            // Atualizar o PlaceHolder com os resultados ordenados
            //UpdatePlaceholder(sortedResults);
        }
    }
}