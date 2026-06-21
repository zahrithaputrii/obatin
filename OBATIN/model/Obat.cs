namespace OBATIN.model
{
    // Model sesuai tabel obat di database
    internal class Obat
    {
        public int IdObat { get; set; }
        public string NamaObat { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
    }
}
