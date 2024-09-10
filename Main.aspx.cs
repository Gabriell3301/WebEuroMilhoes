using EuroMilhoesC_;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebWeb
{
    public partial class Main : System.Web.UI.Page
    {
        List<String> Top5Numbers = new List<String>();
        List<Label> Top5Labels = new List<Label>();
        Analyse analyse = new Analyse();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Card 1
            Top5Labels.Add(Top1);
            Top5Labels.Add(Top2);
            Top5Labels.Add(Top3);
            Top5Labels.Add(Top4);
            Top5Labels.Add(Top5);
            Top5Numbers = analyse.TopFiveNumbers();
            for (int a = 0; a < Top5Labels.Count; a++)
            {
                Top5Labels[a].Text = Top5Numbers[a];
            }
            //Card 2
            LastKey.Text = analyse.LastKey();
        }
        /// <summary>
        /// Problema para Atualizar os valores na base de dados (Dando conflito com a chave estrangeira, mas mesmo depois de tantar mudar a ordem de execução, não funciona), help-me pls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        public void Deleting_Key(object sender, EventArgs e)
        {
            string DataBase_connection = @"Server=PC-INTERN001\SQLEXPRESS;Database=Results;Integrated Security=True;";
            int keyForDelete = 0;
            if (int.TryParse(KeyToDelete.Text, out int a))
            {
                keyForDelete = a;
            }
            using (SqlConnection connection1 = new SqlConnection(DataBase_connection))
            {
                connection1.Open();
                string disableConstraintsSql = @"
                ALTER TABLE [dbo].[Number] NOCHECK CONSTRAINT FK__Number__NumberKe__4BAC3F29;
                ALTER TABLE [dbo].[Star] NOCHECK CONSTRAINT FK__Star__NumberKey__4E88ABD4;";
                using (SqlCommand command = new SqlCommand(disableConstraintsSql, connection1))
                {
                    command.ExecuteNonQuery();
                }
                using (SqlTransaction transaction = connection1.BeginTransaction())
                {
                    try
                    {
                        if (keyForDelete == 0)
                        {
                            throw new Exception("The value of number key cannot be 0.");
                        }
                        string deleteQuery = @"
                        DELETE FROM Result
                        WHERE NumberKey = @KeyForDelete";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection1, transaction))
                        {
                            cmd.Parameters.AddWithValue("@keyForDelete", keyForDelete);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                throw new Exception("Key number not found in the Result table.");
                            }
                        }

                        string updateQuery = @"
                        UPDATE Result
                        SET NumberKey = NumberKey - 1
                        WHERE NumberKey > @keyForDelete;

                        UPDATE Number
                        SET NumberKey = NumberKey - 1
                        WHERE NumberKey > @keyForDelete;

                        UPDATE Star
                        SET NumberKey = NumberKey - 1
                        WHERE NumberKey > @keyForDelete";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection1, transaction))
                        {
                            cmd.Parameters.AddWithValue("@keyForDelete", keyForDelete);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();               
                        connection1.Close();
                        int indexToRemove = Global.results.FindIndex(x => x.NumberKey == keyForDelete);

                        if (indexToRemove != -1)
                        {
                            Global.results.RemoveAt(indexToRemove);
                            foreach (var result in Global.results.Where(x => x.NumberKey > indexToRemove))
                            {
                                result.NumberKey--;
                            }
                            LastKey.Text = analyse.LastKey();
                        }
                        else
                        {
                            throw new Exception("Not found Result with number key.");
                        }


                        //string enableConstraintsSql = @"
                        //        ALTER TABLE [dbo].[Number] WITH CHECK ADD CONSTRAINT FK__Number__NumberKe__4BAC3F29 FOREIGN KEY ([NumberKey]) REFERENCES [dbo].[Result] ([NumberKey]);
                        //        ALTER TABLE [dbo].[Star] WITH CHECK ADD CONSTRAINT FK__Star__NumberKey__4E88ABD4 FOREIGN KEY ([NumberKey]) REFERENCES [dbo].[Result] ([NumberKey]);
                        //        ";

                        //using (SqlCommand command = new SqlCommand(enableConstraintsSql, connection1))
                        //{
                        //    command.ExecuteNonQuery();
                        //}
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        KeyDeleted.Text = ("Error deleting and updating the NumberKey:<br/>" + ex.Message);
                        KeyDeleted.Visible = true;
                    }
                }
            }
        }
    }
}