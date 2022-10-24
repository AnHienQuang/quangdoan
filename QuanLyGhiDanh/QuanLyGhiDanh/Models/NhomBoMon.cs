using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Models
{
    public class NhomBoMon
    {
        public int IdNhomBoMon { get; set; }
        public string NhomBoMonName { get; set; }
    }
}