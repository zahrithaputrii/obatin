using System;
using System.Data;
using OBATIN.konfigurasi;

namespace OBATIN.service
{
    internal class Obat_service
    {
        // Koneksi ke database
        Koneksi koneksi = new Koneksi();

        string Query;

        // Mengambil semua data obat (hanya kolom yang ditampilkan)
        public DataTable viewAll()
        {
            Query = "SELECT id_obat, nama_obat, harga, stok FROM obat ORDER BY nama_obat";
            return koneksi.eksekusiQuery(Query);
        }

        // Mencari obat berdasarkan nama (pencarian tidak case-sensitive)
        public DataTable searchByName(string nama)
        {
            Query = "SELECT id_obat, nama_obat, harga, stok FROM obat " +
                    "WHERE nama_obat LIKE '%" + nama + "%' " +
                    "ORDER BY nama_obat";
            return koneksi.eksekusiQuery(Query);
        }

        // Menambah stok obat berdasarkan id_obat
        public int tambahStok(int id_obat, int jumlah)
        {
            Query = "UPDATE obat SET stok = stok + " + jumlah +
                    " WHERE id_obat = " + id_obat;
            return koneksi.eksekusiNonQuery(Query);
        }
    }
}
