using System;
using System.Data;
using OBATIN.konfigurasi;

namespace OBATIN.service
{
    internal class User_service
    {
        // Koneksi ke database
        Koneksi koneksi = new Koneksi();

        string Query;

        // Login: cek username dan password, kembalikan DataTable berisi data user
        public DataTable login(string username, string password)
        {
            Query = "SELECT * FROM users " +
                    "WHERE username='" + username + "' " +
                    "AND password='" + password + "'";
            return koneksi.eksekusiQuery(Query);
        }
    }
}
