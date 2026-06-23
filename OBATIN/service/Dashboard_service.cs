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
            try
            {
                string query = "SELECT COUNT(*) AS total FROM obat";
                DataTable dt = kon.eksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["total"] != DBNull.Value)
                    return Convert.ToInt32(dt.Rows[0]["total"]);
            }
            catch (Exception) { }
            return 0;
        }

        public int totalStok()
        {
            try
            {
                string query = "SELECT IFNULL(SUM(stok),0) AS total FROM obat";
                DataTable dt = kon.eksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["total"] != DBNull.Value)
                    return Convert.ToInt32(dt.Rows[0]["total"]);
            }
            catch (Exception) { }
            return 0;
        }

        public int totalTransaksi()
        {
            try
            {
                string query = "SELECT COUNT(*) AS total FROM penjualan";
                DataTable dt = kon.eksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["total"] != DBNull.Value)
                    return Convert.ToInt32(dt.Rows[0]["total"]);
            }
            catch (Exception) { }
            return 0;
        }

        public decimal totalPenjualan()
        {
            try
            {
                string query = "SELECT IFNULL(SUM(total_bayar),0) AS total FROM penjualan";
                DataTable dt = kon.eksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["total"] != DBNull.Value)
                    return Convert.ToDecimal(dt.Rows[0]["total"]);
            }
            catch (Exception) { }
            return 0;
        }
    }
}