using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;

namespace SalveDinheiro.DAO
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;   // will be used to open a connection to the database
        private string database; // indicates where our server is hosted "localhost"
        private string uid;      // is MySQL  username
        private string password; // is MYSQL password

        public DBConnect()
        {
            Initializer();

        }

        // this private method initialize values
        private void Initializer()
        {
            this.server = "";
            this.database = "";
            this.uid = "";
            this.password = "";
            string connectionString;
            connectionString = $"SERVER={server}\nDATABASE={database}\nUID={uid}\nPASSWORD={password}";
            connection = new MySqlConnection(connectionString);
            Console.WriteLine("initializou");
        }
        
        // this private method open the connection to database and verify if the connection was open
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            } 
            catch(MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        // this private method close to database and verify  if the connection was close
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException e)
            {
                Console.WriteLine("ERRO");
                return false;
            }
        }

        /*
         *  ExecuteNonQuery  => It's used to execute a command that will not return any data, for example "Insert", "Update" or "Delete";
         *  ExecuteReader =>  It's used to execute a command that wiill return 0 or more records, for exemple "Select".
         *  ExecuteScalar => It's used to execute a command that will return only 1 value, for example "Select count(*)"
         *
         */
        public void Insert(int id,string numeroConta,double saldo)
        {
            string query = $"SELECT INTO CONTA (ID, NUMERO_CONTA,SALDO) VALUES ({id},{numeroConta},{saldo})";

            if (OpenConnection())
            {
                MySqlCommand comand = new MySqlCommand(query, connection);
                comand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
        /*
        public List<string> [] Select()
        {

        }
        */
    }
}
