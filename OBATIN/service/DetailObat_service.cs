using System;
using System.Data;
using OBATIN.konfigurasi;

namespace OBATIN.service
{
    internal class DetailObat_service
    {
        Koneksi koneksi = new Koneksi();
        string Query;

        // Ambil data detail obat berdasarkan id_obat
        public DataTable getByObatId(int idObat)
        {
            Query = "SELECT id_detail_obat, id_obat, manfaat, dosis, efek_samping, kontraindikasi " +
                    "FROM detail_obat WHERE id_obat = " + idObat;
            return koneksi.eksekusiQuery(Query);
        }

        // Menyimpan detail obat (insert jika belum ada, update jika sudah ada)
        public int simpanDetail(int idObat, string manfaat, string dosis, string efekSamping, string kontraindikasi)
        {
            // Ambil detail saat ini untuk mengecek eksistensi
            DataTable dt = getByObatId(idObat);

            string safeManfaat = manfaat.Replace("'", "''");
            string safeDosis = dosis.Replace("'", "''");
            string safeEfekSamping = efekSamping.Replace("'", "''");
            string safeKontraindikasi = kontraindikasi.Replace("'", "''");

            if (dt.Rows.Count > 0)
            {
                // Jika sudah ada, lakukan UPDATE
                Query = "UPDATE detail_obat SET " +
                        "manfaat = '" + safeManfaat + "', " +
                        "dosis = '" + safeDosis + "', " +
                        "efek_samping = '" + safeEfekSamping + "', " +
                        "kontraindikasi = '" + safeKontraindikasi + "' " +
                        "WHERE id_obat = " + idObat;
            }
            else
            {
                // Jika belum ada, lakukan INSERT
                Query = "INSERT INTO detail_obat (id_obat, manfaat, dosis, efek_samping, kontraindikasi) VALUES (" +
                        idObat + ", " +
                        "'" + safeManfaat + "', " +
                        "'" + safeDosis + "', " +
                        "'" + safeEfekSamping + "', " +
                        "'" + safeKontraindikasi + "')";
            }

            return koneksi.eksekusiNonQuery(Query);
        }
    }
}
