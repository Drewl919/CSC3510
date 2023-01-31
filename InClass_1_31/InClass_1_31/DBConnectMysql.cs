﻿
using MySqlConnector;

namespace InClass_1_31 {
    internal class DBConnectMysql {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnectMysql() {
            Initialize();
        }

        private void Initialize() {
            server = "45.55.136.114";
            database = "csc3610";
            uid = "csc3610";
            password = "csc3610";
            //string conString = "SERVER=" + server + "; DATABASE=" +
            string conString = String.Format("SERVER={0}; DATABASE={1}; UID={2}; PASSWORD={3}", server, database, uid, password);
            connection = new MySqlConnection(conString);
            Console.WriteLine("It must have connected");
        }
        public bool OpenConnection() {
            bool result = false;

            try {
                connection.Open();
                result = true;
            } catch (MySqlException ex) {
                switch (ex.Number) {
                    case 0:
                        Console.WriteLine("Cannot connect to server");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid user/passwd");
                        break;
                    default:
                        Console.WriteLine("It broke");
                        break;
                }
            }
            return result;
        }
        public List<Candy> Select() {
            List<Candy> result = new List<Candy>();
            string q = "SELECT id,item,count,cost FROM candy";
            if(this.OpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(q, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()) {
                    int id = dr.GetInt32(0);
                    string itm = dr.GetString(1);
                    int ct = dr.GetInt32(2);
                    decimal cost = dr.GetDecimal(3);
                    result.Add(new Candy(id, itm, ct, cost));
                }
                this.connection.Close();
            } else {
                Console.WriteLine("Connect did not open");
            }
            return result;
        }
        public void Insert(string item, int count, decimal cost) {
            string q = string.Format("INSERT INTO candy (item, count, cost) VALUES('{0}','{1}','{2}')", item, count, cost);
            if(this.OpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(q, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                this.connection.Close();
            } else {
                Console.WriteLine("FL2: Connect did not open");
            }

        }

    }
}
