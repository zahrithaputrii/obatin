using System;
using System.Data;
using OBATIN.konfigurasi;

namespace OBATIN.service
{
    internal class Penjualan_service
    {
        // Koneksi ke database
        Koneksi koneksi = new Koneksi();

        string Query;

        // Mengambil semua riwayat transaksi
        public DataTable viewAll()
        {
            Query = "SELECT no_nota AS 'No Nota', tanggal AS 'Tanggal', " +
                    "kasir AS 'Kasir', total_bayar AS 'Total Bayar' " +
                    "FROM penjualan ORDER BY tanggal DESC";
            return koneksi.eksekusiQuery(Query);
        }

        // Mencari riwayat berdasarkan tanggal tertentu
        public DataTable searchByTanggal(string tanggal)
        {
            Query = "SELECT no_nota AS 'No Nota', tanggal AS 'Tanggal', " +
                    "kasir AS 'Kasir', total_bayar AS 'Total Bayar' " +
                    "FROM penjualan " +
                    "WHERE DATE(tanggal) = '" + tanggal + "' " +
                    "ORDER BY tanggal DESC";
            return koneksi.eksekusiQuery(Query);
        }

        // Generate nomor nota otomatis
        public string generateNoNota()
        {
            string dateStr = DateTime.Now.ToString("yyyyMMdd");
            string prefix = "NT" + dateStr;

            Query = "SELECT no_nota FROM penjualan " +
                    "WHERE no_nota LIKE '" + prefix + "%' " +
                    "ORDER BY no_nota DESC LIMIT 1";

            DataTable dt = koneksi.eksekusiQuery(Query);

            if (dt.Rows.Count > 0)
            {
                string lastNota = dt.Rows[0]["no_nota"].ToString();
                if (lastNota.Length >= 10)
                {
                    string numStr = lastNota.Substring(prefix.Length);
                    int lastNum = 0;
                    if (int.TryParse(numStr, out lastNum))
                    {
                        return prefix + (lastNum + 1).ToString("D3");
                    }
                }
            }

            return prefix + "001";
        }

        // Simpan data ke tabel penjualan, kembalikan id_penjualan yang baru
        public int simpanPenjualan(string noNota, string tanggal, string kasir, double totalBayar)
        {
            string totalStr = totalBayar.ToString(System.Globalization.CultureInfo.InvariantCulture);
            Query = "INSERT INTO penjualan (no_nota, tanggal, kasir, total_bayar) " +
                    "VALUES ('" + noNota + "', '" + tanggal + "', '" + kasir + "', " + totalStr + ")";
            koneksi.eksekusiNonQuery(Query);

            // Ambil id berdasarkan no_nota yang unik
            DataTable dt = koneksi.eksekusiQuery("SELECT id_penjualan FROM penjualan WHERE no_nota = '" + noNota + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["id_penjualan"]);
            }
            return 0;
        }

        // Simpan detail transaksi ke tabel detail_penjualan
        public int simpanDetail(int idPenjualan, int idObat, string namaObat, double harga, int jumlah, double subtotal)
        {
            string hargaStr = harga.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string subtotalStr = subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
            Query = "INSERT INTO detail_penjualan (id_penjualan, id_obat, nama_obat, harga, jumlah, subtotal) " +
                    "VALUES (" + idPenjualan + ", " + idObat + ", '" + namaObat.Replace("'", "''") + "', " +
                    hargaStr + ", " + jumlah + ", " + subtotalStr + ")";
            return koneksi.eksekusiNonQuery(Query);
        }

        // Kurangi stok obat setelah transaksi
        public int kurangiStok(int idObat, int jumlah)
        {
            Query = "UPDATE obat SET stok = stok - " + jumlah +
                    " WHERE id_obat = " + idObat;
            return koneksi.eksekusiNonQuery(Query);
        }
    }
}
