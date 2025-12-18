using latihan1.Models;
using Microsoft.AspNetCore.Mvc;

namespace latihan1.Data
{
    public static class BarangData
    {
        public static Barang[] Data = new Barang[]
        {
            new Barang { Id = 1, Kode = "BRG001", Nama = "Gula Pasir", Stok = 50, Gudang = "Gudang A" },
            new Barang { Id = 2, Kode = "BRG002", Nama = "Beras", Stok = 100, Gudang = "Gudang B" },
            new Barang { Id = 3, Kode = "BRG003", Nama = "Minyak Goreng", Stok = 75, Gudang = "Gudang A" },
            new Barang { Id = 4, Kode = "BRG004", Nama = "Tepung Terigu", Stok = 40, Gudang = "Gudang C" }
        };


    }
}
