using MySqlConnector;

namespace Ultraverse.Manager
{
    public class MySQLManager
    {
        public MySqlConnection Connection { get; init; }
        public MySqlDataReader? Reader { get; set; }
        public MySqlTransaction? Transaction { get; set; }

    }
}
