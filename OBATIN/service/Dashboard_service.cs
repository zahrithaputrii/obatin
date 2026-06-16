using System;
using System.Data;
using OBATIN.konfigurasi;

namespace OBATIN.service
{
    internal class Dashboard_service
    {
        Koneksi kon = new Koneksi();

        public int totalObat()
        {
            string query = "SELECT COUNT(*) AS total FROM obat";
            DataTable dt = kon.eksekusiQuery(query);

            return Convert.ToInt32(dt.Rows[0]["total"]);
        }

        public int totalStok()
        {
            string query = "SELECT IFNULL(SUM(stok),0) AS total FROM obat";
            DataTable dt = kon.eksekusiQuery(query);

            return Convert.ToInt32(dt.Rows[0]["total"]);
        }

        public int totalTransaksi()
        {
            string query = "SELECT COUNT(*) AS total FROM penjualan";
            DataTable dt = kon.eksekusiQuery(query);

            return Convert.ToInt32(dt.Rows[0]["total"]);
        }

        public decimal totalPenjualan()
        {
            string query = "SELECT IFNULL(SUM(total_bayar),0) AS total FROM penjualan";
            DataTable dt = kon.eksekusiQuery(query);

            return Convert.ToDecimal(dt.Rows[0]["total"]);
        }
    }
}