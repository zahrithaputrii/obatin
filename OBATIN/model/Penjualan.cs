using System;

namespace OBATIN.model
{
    // Model sesuai tabel penjualan di database
    internal class Penjualan
    {
        public int IdPenjualan { get; set; }
        public string NoNota { get; set; }
        public DateTime Tanggal { get; set; }
        public string Kasir { get; set; }
        public decimal TotalBayar { get; set; }
    }
}
