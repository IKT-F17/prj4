using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.MemoryMappedFiles;
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
                Username = "",
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

        void AddAccount(ref User user)
        {
            string insertStringParam = @"INSERT INTO User (password, username, totalHighscore, mapScore, name)
                                            OUTPUT user.Username
                                            VALUES (@Password, @Username, @TotalHighscore, @MapScore, @Name)";

            using (SQLCommand cmd = New SQLCommand(InsertStringParam, OpenConnection))
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

        void GetMap(ref MapFilePath mapFile) //return string of mapfilepath
        {

        }


        void CreateAccount(ref User user) //if username exists don't create
        {

        }

        void DeleteAccount(ref User user) //delete only if username exists
        {

        }

        void ChangeAccountPassword(ref User user) 
        {

        }

        void GetLeaderBoard(ref User user) //return all the scores and add in list. THen sort list and take top 10. (quicksort)
        {

        }

        void GetAccountScore(ref User user) //returns value of score
        {

        }

        void GetAccountMapScore(ref User user, Map name) //returns score for a specific map for a specific Account
        {

        }

        void AddMap(ref MapFilePath mapFilePath, Map name) //add a string of the filepath for the map file and map name to class map
        {
            
        }

        void DeleteMap(ref MapFilePath mapFilePath, Map name) //delete a string of the filepath for the map file and map name on class map
        {

        }
    }
}
