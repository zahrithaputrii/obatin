namespace OBATIN.model
{
    // Model sesuai tabel users di database
    internal class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
