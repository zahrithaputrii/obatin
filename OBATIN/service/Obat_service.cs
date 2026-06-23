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
            Query = "SELECT id_obat, nama_obat, harga, stok, kategori FROM obat ORDER BY nama_obat";
            return koneksi.eksekusiQuery(Query);
        }

        // Mencari obat berdasarkan nama (pencarian tidak case-sensitive)
        public DataTable searchByName(string nama)
        {
            Query = "SELECT id_obat, nama_obat, harga, stok, kategori FROM obat " +
                    "WHERE nama_obat LIKE '%" + nama.Replace("'", "''") + "%' " +
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

        // Menambahkan obat baru ke database
        public int tambahObat(string namaObat, decimal harga, int stok, string kategori)
        {
            string safeNama = namaObat.Replace("'", "''");
            string safeKategori = kategori.Replace("'", "''");
            string hargaStr = harga.ToString(System.Globalization.CultureInfo.InvariantCulture);

            Query = "INSERT INTO obat (nama_obat, harga, stok, kategori) VALUES (" +
                    "'" + safeNama + "', " +
                    hargaStr + ", " +
                    stok + ", " +
                    "'" + safeKategori + "')";
            return koneksi.eksekusiNonQuery(Query);
        }
    }
}
