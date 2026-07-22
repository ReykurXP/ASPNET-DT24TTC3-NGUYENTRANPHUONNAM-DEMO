using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinhKienDienTu.Models
{
    public class LinhKien
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string TenLinhKien { get; set; }

        public double GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string HinhAnh { get; set; }

        public int DanhMucId { get; set; }
        [ForeignKey("DanhMucId")]
        public DanhMuc DanhMuc { get; set; }
    }
}