
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Modes
{

    public class HocVien
    {
        public int IdHocVien { get; set; }
        public string HocVienName { get; set; }
        public string DiaChiHV { get; set; }
        public string AnhDaiDienHV { get; set; }
        public int SDTPhuHuynh { get; set; }

    }
}
