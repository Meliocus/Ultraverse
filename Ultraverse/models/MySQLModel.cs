using MySqlConnector;

namespace Ultraverse.models
{
    public struct MySQLModel
    {
        public required string Server { get; init; }
        public required string Database { get; init; }
        public required string Username { get; init; }
        public required string Password { get; init; }
        public string ConnectionString => $"server={Server};database={Database};uid={Username};pwd={Password};";
    }
}
