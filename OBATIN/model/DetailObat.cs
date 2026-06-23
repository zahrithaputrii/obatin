namespace OBATIN.model
{
    // Model sesuai tabel detail_obat di database
    internal class DetailObat
    {
        public int IdDetailObat { get; set; }
        public int IdObat { get; set; }
        public string Manfaat { get; set; }
        public string Dosis { get; set; }
        public string EfekSamping { get; set; }
        public string Kontraindikasi { get; set; }
    }
}
