using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinhKienDienTu.Models
{
    public class DanhMuc
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDanhMuc { get; set; }

        public string MoTa { get; set; }

        public ICollection<LinhKien> LinhKiens { get; set; }
    }
}