namespace WebApplication1
{
    public class Connect
    {
        public MySqlConnection? Connection;

        private string _host;
        private string _db;
        private string _user;
        private string _password;

        private string _ConnectionString;


        public Connect()
        {
            _host = "localhost";
            _db = "library";
            _user = "root";
            _password = " ";

            _ConnectionString = $"SERVER={_host}; DATABASE={_db};UID={_user}; PASSWORD={_password};SslMode=none";

            Connection = new MySqlConnection(_ConnectionString);


        }
    }
}
