using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;

namespace DotnetCoreServer.Models
{
    public interface IPlayerDao{
        Player FindPIDByPAD(string PlayerAddress);
        Player InsertUser(Player player);
        Player GetPlayer(int PlayerID);
    }

    public class PlayerDao : IPlayerDao
    {
        public IDB db {get;}

        public PlayerDao(IDB db){
            this.db = db;
        }

        public Player GetPlayer(int PlayerID)
        {
            Player player = new Player();
            using (MySqlConnection conn = db.GetConnection())
            {
                string query = String.Format(
                    @"
                    SELECT 
                        player_id, player_address,
                    FROM player_tb 
                    WHERE player_id = {0}",
                     PlayerID);

                Console.WriteLine(query);

                using (MySqlCommand cmd = (MySqlCommand)conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    using (MySqlDataReader reader = (MySqlDataReader)cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            player.PlayerID = reader.GetInt32(0);
                            player.PlayerAddress = reader.GetString(1);
                        }
                    }
                }

                conn.Close();
            }
            return player;
        }

        public Player FindPIDByPAD(string PlayerAddress)
        {
            Player player = new Player();
            using (MySqlConnection conn = db.GetConnection())
            {
                string query = String.Format(
                    "Select player_id where player_address = '{0}'",
                    PlayerAddress);

                Console.WriteLine(query);

                using(MySqlCommand cmd = (MySqlCommand)conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    using(MySqlDataReader reader = (MySqlDataReader)cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            player.PlayerID = reader.GetInt32(0);

                            return player;
                        }
                    }
                }
                conn.Close();
            }
                return null;
        }
       

        public Player InsertUser(Player player){
            
            string query = String.Format(
                "INSERT INTO player_tb (player_address) VALUES ('{0}')",
                    player.PlayerAddress);

            Console.WriteLine(query);

            using(MySqlConnection conn = db.GetConnection())
            using(MySqlCommand cmd = (MySqlCommand)conn.CreateCommand())
            {

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                conn.Close();
            }

        
            return player;
        }



    }
}