using latihan1.Models;

namespace latihan1.Data
{
    public static class BarangData
    {
        public static List<Barang> ListBarang = new()
        {
            new Barang { Id = 1, Kode = "K001", Nama = "Sabun Lifebouy", Guadang= "G001", Stok= 30 },
            new Barang { Id = 2, Kode = "K002", Nama = "Sunlight Jeruk Nipis Pencuci piring", Guadang = "G002", Stok = 12},
            new Barang { Id = 3, Kode = "K003", Nama = "Pepsodent 250gr", Guadang = "G003", Stok = 50 }
        };
    }
}
