namespace webDangKiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lichdangkiem")]
    public partial class lichdangkiem
    {
        [Key]
        public int maLDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayDangkiem { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayHethan { get; set; }

        public int maCPT { get; set; }

        public int maPT { get; set; }

        public int maTT { get; set; }

        public virtual chuphuongtien chuphuongtien { get; set; }

        public virtual phuongtien phuongtien { get; set; }

        public virtual trungtam trungtam { get; set; }
    }
}
