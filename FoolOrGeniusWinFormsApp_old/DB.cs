using MySql.Data.MySqlClient;

namespace FoolOrGeniusWinFormsApp
{
    internal class DB
    {
        private MySqlConnection connection = new MySqlConnection("server= localhost; port=3306; username=root; password=root; database=foolorgenius");

        public void openConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if(connection.State==System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
