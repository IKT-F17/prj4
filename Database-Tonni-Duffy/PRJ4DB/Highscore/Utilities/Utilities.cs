﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.MemoryMappedFiles;
using System.Net;
using System.Text.RegularExpressions;
//using System.Security.AccessControl;

using Highscore;



namespace Highscore.Utilities
{
    class Utilities
    {
        public Utilities()
        {
            var user = new User()
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



        private SqlConnection OpenConnection
        {
            get
            {
                var con = new SqlConnection(
                    // ADD DB Connectionstring here. 
                );
                con.Open();
                return con;
            }
        }


        void AddAccount(ref User user)
        {
            string insertStringParam = @"INSERT INTO User (password, username, totalHighscore, mapScore, name)
                                            OUTPUT user.Username
                                            VALUES (@Password, @Username, @TotalHighscore, @MapScore, @Name)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
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
            string updateStringParam = @"Update User
                                            Set totalHighscore = @TotalHighscore, mapScore = @MapScore
                                            WHERE username = @Username AND name = @Name";

            using (SqlCommand cmd = new SqlCommand(updateStringParam, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@TotalHighscore", user.Scores.TotalHighscore);
                cmd.Parameters.AddWithValue("@MapScore", user.Scores.Map.MapScore);
                cmd.ExecuteNonQuery();
            }
        }

        void GetMap(ref MapFilePath mapFile) //return string of mapfilepath
        {

        }


        void DeleteAccount(ref User user) //delete only if username exists
        {
            string DeleteString = @"DELETE FROM User WHERE (Username=@Username)";
            using (SqlCommand cmd = new SqlCommand(DeleteString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Username", user.Username);
                var count = cmd.ExecuteNonQuery(); //Vi bruger måske ikke count til noget ? men den er ikke til nogen skade .
                user = null;
            }
        }



        void ChangeAccountPassword(ref User user)
        {
            string updateStringParam = @"UPDATE User 
                                                SET Password=@Password
                                                WHERE Username=@Username";

            using (SqlCommand cmd = new SqlCommand(updateStringParam, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Password", user.Password);
                var count = cmd.ExecuteNonQuery();
            }


        }

        void GetLeaderBoard(ref User user) //return all the scores and add in list. Then sort list and take top 10. (quicksort)
        {

        }

        int GetAccountScore(ref User user) //returns value of score
        {
            string selectStringParam = @"SELECT FROM User WHERE (Username=@Username)";

            using (SqlCommand cmd = new SqlCommand(selectStringParam, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Username", user.Username);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    user.Scores.TotalHighscore = (int) rdr["TotalHighScore"];
                    return user.Scores.TotalHighscore;
                }

                return 0;
            }
        }

        int GetAccountMapScore(ref User user, string name) //returns score for a specific map for a specific Account
        {
            string selectStringParam = @"SELECT FROM User WHERE Username=@Username AND Name=@Name";

            using (SqlCommand cmd = new SqlCommand(selectStringParam, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Name", user.Scores.Map.Name);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() && (string)rdr["Name"] == name)
                {
                    user.Scores.Map.MapScore = (int) rdr["MapScore"];
                    return user.Scores.Map.MapScore;
                }

                return 0;
            }
        }

        void AddMap(ref MapFilePath mapFilePath, Map name) //add a string of the filepath for the map file and map name to class map
        {
            
        }

        void DeleteMap(ref MapFilePath mapFilePath, Map name) //delete a string of the filepath for the map file and map name on class map
        {

        }
    }
}
