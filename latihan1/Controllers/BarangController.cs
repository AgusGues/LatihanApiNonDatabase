using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using latihan1.Data;
using latihan1.Models;

namespace latihan1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangController : ControllerBase
    {
       // GET: api/barang
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(BarangData.Data);
        }

        // GET: api/barang/search?keyword=beras
        [HttpGet("search")]
        public IActionResult Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return Ok(BarangData.Data);

            var result = BarangData.Data
                .Where(b =>
                    b.Nama.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    b.Kode.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    b.Gudang.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToArray();

            return Ok(result);
        }
    }
}
