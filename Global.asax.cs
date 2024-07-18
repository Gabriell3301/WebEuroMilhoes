using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebWeb
{
    public class Global : System.Web.HttpApplication
    {
        internal static List<Results> results = new List<Results>();
        /// <summary>
        /// Start Web
        /// </summary>
        protected void Application_Start(object sender, EventArgs e)
        {
            DataBase.LoadValuesFromDatabase();
        }
        protected void Application_End(object sender, EventArgs e)
        {
            
        }
    }
}