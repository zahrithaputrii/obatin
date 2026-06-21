namespace OBATIN.model
{
    // Model sesuai tabel detail_penjualan di database
    internal class DetailPenjualan
    {
        public int IdDetail { get; set; }
        public int IdPenjualan { get; set; }
        public int IdObat { get; set; }
        public string NamaObat { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public decimal Subtotal { get; set; }
    }
}
