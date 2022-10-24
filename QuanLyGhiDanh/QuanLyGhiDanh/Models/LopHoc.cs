using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Models
{
    public class LopHoc
    {
        public int IdLopHoc { get; set; }
        public string NgayHoc { get; set; }
        public string GioHoc { get; set; }
        public string HocPhi { get; set; }
        public string PhongHoc { get; set; }

    }
}
