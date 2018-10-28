using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Security.AccessControl;

namespace Highscore.Utilities
{
    class Utilities
    {
        public Utilities()
        {
            user = new User()
            {
                Password = "",
                Username ="",
                Scores =
                {
                    TotalHighscore = 0,
                    Map = 
                    {
                        MapScore = 0,
                        Name = ""
                    }
                }
            };

        }


        /*Add sql connection here

            xxxxxxxxxxxxxxxxxxxxxxxxxx

        */

        void AddUser(ref User user)
        {
            string insertStringParam = @"INSERT INTO User (password, username, totalHighscore, mapScore, name)
                                            OUTPUT user.Username
                                            VALUES (@Password, @Username, @TotalHighscore, @MapScore, @Name)";
            
            using (SQLCommand cmd = New SQLCommand(InsertStringParam,OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@TotalHighscore", user.Scores.TotalHighscore);
                cmd.Parameters.AddWithValue("@MapScore", user.Scores.Map.MapScore);
                cmd.Parameters.AddWithValue("@Name", user.Scores.Map.Name);
                cmd.ExecuteNonQuery();
            }
        }

        void UpdateScore(ref User user)
        {
            string InsertStringParam = @"Update User
                                            Set totalHighscore = @TotalHighscore, mapScore = @MapScore
                                            WHERE username = @Username AND name = @Name";

            using (SQLCommand cmd = New SQLCommand(InsertStringParam, OpenConnection))
            {
                cmd.Parameters.AddwithValue("@TotalHighscore", user.Scores.TotalHighscore);
                cmd.Parameters.AddwithValue("@MapScore", user.Scores.Map.MapScore);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
