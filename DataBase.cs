using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using WebWeb;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EuroMilhoesC_
{
    internal class DataBase
    {
        public static void LoadValuesFromDatabase()
        {

            string connectionString = @"Server=PC-INTERN001\SQLEXPRESS;Database=Results;Integrated Security=True;";

            // SQL para buscar dados da tabela Key
            string selectKeyQuery = "SELECT NumberKey, Date, Winner, Gain FROM Result";

            // SQL para buscar dados da tabela Numbers
            string selectNumbersQuery = "SELECT Number1, Number2, Number3, Number4, Number5 FROM Number WHERE NumberKey = @Number_Key";

            // SQL para buscar dados da tabela Stars
            string selectStarsQuery = "SELECT Star1, Star2 FROM Star WHERE NumberKey = @Number_Key";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir conexão
                    connection.Open();

                    // Buscar dados da tabela Key
                    using (SqlCommand command = new SqlCommand(selectKeyQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int numberKey = reader.GetInt32(0);
                                DateTime date = reader.GetDateTime(1);
                                int winner = reader.GetInt32(2);
                                long gain = reader.GetInt64(3);

                                var result = new Results
                                {
                                    NumberKey = numberKey,
                                    Winner = winner,
                                    Gain = gain,
                                    Numbers = new List<int>(),
                                    Stars = new List<int>()
                                };

                                // Buscar dados da tabela Numbers para o número-chave atual
                                using (SqlConnection numbersConnection = new SqlConnection(connectionString))
                                {
                                    numbersConnection.Open();

                                    using (SqlCommand numbersCommand = new SqlCommand(selectNumbersQuery, numbersConnection))
                                    {
                                        numbersCommand.Parameters.AddWithValue("@Number_Key", numberKey);

                                        using (SqlDataReader numbersReader = numbersCommand.ExecuteReader())
                                        {
                                            if (numbersReader.Read())
                                            {
                                                result.Numbers.Add(numbersReader.GetInt32(0));
                                                result.Numbers.Add(numbersReader.GetInt32(1));
                                                result.Numbers.Add(numbersReader.GetInt32(2));
                                                result.Numbers.Add(numbersReader.GetInt32(3));
                                                result.Numbers.Add(numbersReader.GetInt32(4));
                                            }
                                        }
                                    }
                                }

                                // Usar uma nova conexão para buscar dados da tabela Stars
                                using (SqlConnection starsConnection = new SqlConnection(connectionString))
                                {
                                    starsConnection.Open();

                                    using (SqlCommand starsCommand = new SqlCommand(selectStarsQuery, starsConnection))
                                    {
                                        starsCommand.Parameters.AddWithValue("@Number_Key", numberKey);

                                        using (SqlDataReader starsReader = starsCommand.ExecuteReader())
                                        {
                                            if (starsReader.Read())
                                            {
                                                result.Stars.Add(starsReader.GetInt32(0));
                                                result.Stars.Add(starsReader.GetInt32(1));
                                            }
                                        }
                                    }
                                    // Adicionar o resultado à lista
                                    Global.results.Add(result);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        public static bool SaveLastResultInDataBase()
        {

            // Conexão com a base de dados
            string connectionString = @"Server=PC-INTERN001\SQLEXPRESS;Database=Results;Integrated Security=True;";

            // SQL para inserir dados na tabela Key
            string insertResultQuery = @"
            INSERT INTO Result (NumberKey, Date, Winner, Gain)
            VALUES (@NumberKey, @Date, @Winner, @Gain)";

            // SQL para inserir dados na tabela Number
            string insertNumbersQuery = @"
            INSERT INTO Number (NumberKey, Number1, Number2, Number3, Number4, Number5)
            VALUES (@NumberKey, @Number1, @Number2, @Number3, @Number4, @Number5)";

            // SQL para inserir dados na tabela Star
            string insertStarsQuery = @"
            INSERT INTO Star (NumberKey, Star1, Star2)
            VALUES (@NumberKey, @Star1, @Star2)";

            string checkKeyExistsQuery = "SELECT COUNT(*) FROM Result WHERE NumberKey = @NumberKey";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand checkCommand = new SqlCommand(checkKeyExistsQuery, connection))
                    {
                        int a = Global.results.Last().NumberKey;
                        checkCommand.Parameters.AddWithValue("@NumberKey", a);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // Chave já existe, ignorar a inserção
                            Console.WriteLine($"The key with NumberKey {Global.results.Last().NumberKey} already exists. Ignoring...");
                            return false;
                        }
                    }

                    // Inserir dados na tabela Result
                    using (SqlCommand resultCommand = new SqlCommand(insertResultQuery, connection))
                    {
                        resultCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        resultCommand.Parameters.AddWithValue("@Date", Global.results.Last().Date);
                        resultCommand.Parameters.AddWithValue("@Winner", Global.results.Last().Winner);
                        resultCommand.Parameters.AddWithValue("@Gain", Global.results.Last().Gain);

                        resultCommand.ExecuteNonQuery();
                    }

                    // Inserir dados na tabela Number
                    using (SqlCommand numbersCommand = new SqlCommand(insertNumbersQuery, connection))
                    {
                        numbersCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        numbersCommand.Parameters.AddWithValue("@Number1", Global.results.Last().Numbers.ElementAtOrDefault(0));
                        numbersCommand.Parameters.AddWithValue("@Number2", Global.results.Last().Numbers.ElementAtOrDefault(1));
                        numbersCommand.Parameters.AddWithValue("@Number3", Global.results.Last().Numbers.ElementAtOrDefault(2));
                        numbersCommand.Parameters.AddWithValue("@Number4", Global.results.Last().Numbers.ElementAtOrDefault(3));
                        numbersCommand.Parameters.AddWithValue("@Number5", Global.results.Last().Numbers.ElementAtOrDefault(4));

                        numbersCommand.ExecuteNonQuery();
                    }

                    // Inserir dados na tabela Star
                    using (SqlCommand starsCommand = new SqlCommand(insertStarsQuery, connection))
                    {
                        starsCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        starsCommand.Parameters.AddWithValue("@Star1", Global.results.Last().Stars.ElementAtOrDefault(0));
                        starsCommand.Parameters.AddWithValue("@Star2", Global.results.Last().Stars.ElementAtOrDefault(1));

                        starsCommand.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static void SaveResultsInDataBase()
        {
            // Conexão com a base de dados
            string connectionString = @"Server=PC-INTERN001\SQLEXPRESS;Database=Results;Integrated Security=True;";

            // SQL para inserir dados na tabela Key
            string insertResultQuery = @"
            INSERT INTO Result (NumberKey, Date, Winner, Gain)
            VALUES (@NumberKey, @Date, @Winner, @Gain)";

            // SQL para inserir dados na tabela Number
            string insertNumbersQuery = @"
            INSERT INTO Number (NumberKey, Number1, Number2, Number3, Number4, Number5)
            VALUES (@NumberKey, @Number1, @Number2, @Number3, @Number4, @Number5)";

            // SQL para inserir dados na tabela Star
            string insertStarsQuery = @"
            INSERT INTO Star (NumberKey, Star1, Star2)
            VALUES (@NumberKey, @Star1, @Star2)";

            string checkKeyExistsQuery = "SELECT COUNT(*) FROM Result WHERE NumberKey = @NumberKey";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand checkCommand = new SqlCommand(checkKeyExistsQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // Chave já existe, ignorar a inserção
                            Console.WriteLine($"The key with NumberKey {Global.results.Last().NumberKey} already exists. Ignoring...");
                            return;
                        }
                    }

                    // Inserir dados na tabela Result
                    using (SqlCommand resultCommand = new SqlCommand(insertResultQuery, connection))
                    {
                        resultCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        resultCommand.Parameters.AddWithValue("@Date", Global.results.Last().Date);
                        resultCommand.Parameters.AddWithValue("@Winner", Global.results.Last().Winner);
                        resultCommand.Parameters.AddWithValue("@Gain", Global.results.Last().Gain);

                        resultCommand.ExecuteNonQuery();
                    }

                    // Inserir dados na tabela Number
                    using (SqlCommand numbersCommand = new SqlCommand(insertNumbersQuery, connection))
                    {
                        numbersCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        numbersCommand.Parameters.AddWithValue("@Number1", Global.results.Last().Numbers.ElementAtOrDefault(0));
                        numbersCommand.Parameters.AddWithValue("@Number2", Global.results.Last().Numbers.ElementAtOrDefault(1));
                        numbersCommand.Parameters.AddWithValue("@Number3", Global.results.Last().Numbers.ElementAtOrDefault(2));
                        numbersCommand.Parameters.AddWithValue("@Number4", Global.results.Last().Numbers.ElementAtOrDefault(3));
                        numbersCommand.Parameters.AddWithValue("@Number5", Global.results.Last().Numbers.ElementAtOrDefault(4));

                        numbersCommand.ExecuteNonQuery();
                    }

                    // Inserir dados na tabela Star
                    using (SqlCommand starsCommand = new SqlCommand(insertStarsQuery, connection))
                    {
                        starsCommand.Parameters.AddWithValue("@NumberKey", Global.results.Last().NumberKey);
                        starsCommand.Parameters.AddWithValue("@Star1", Global.results.Last().Stars.ElementAtOrDefault(0));
                        starsCommand.Parameters.AddWithValue("@Star2", Global.results.Last().Stars.ElementAtOrDefault(1));

                        starsCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        public static void MenssageSave(Label label, bool Sucsses, List<int> countError)
        {
            if (Sucsses)
            {
                label.Text = "Key saved successfully.";
                label.ForeColor = System.Drawing.Color.Green;
                label.Visible = true;
            }
            else
            {
                if (countError.Count() == 0)
                {
                    label.Text = "Error the key was not saved";
                    label.ForeColor = System.Drawing.Color.Red;
                    label.Visible = true;
                }
                else
                {
                    label.Text = $"Error in the Keys: {String.Join(",", countError)}";
                    label.ForeColor = System.Drawing.Color.Red;
                    label.Visible = true;
                }
            }
        }
    }
}
