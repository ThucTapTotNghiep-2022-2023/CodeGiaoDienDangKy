namespace webDangKiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phuongtien")]
    public partial class phuongtien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phuongtien()
        {
            lichdangkiems = new HashSet<lichdangkiem>();
        }

        [Key]
        public int maPT { get; set; }

        [Required]
        [StringLength(100)]
        public string bienSoxe { get; set; }

        [Required]
        [StringLength(100)]
        public string loaiXe { get; set; }

        public int loaiBien { get; set; }

        public int maCPT { get; set; }

        public virtual chuphuongtien chuphuongtien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lichdangkiem> lichdangkiems { get; set; }
    }
}
