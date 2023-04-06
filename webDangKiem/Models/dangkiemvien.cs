namespace webDangKiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dangkiemvien")]
    public partial class dangkiemvien
    {
        [Key]
        public int maDKV { get; set; }

        [Required]
        [StringLength(100)]
        public string hoVaten { get; set; }

        [Required]
        [StringLength(100)]
        public string tenDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string matKhau { get; set; }
    }
}
