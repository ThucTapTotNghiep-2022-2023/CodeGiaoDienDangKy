namespace webDangKiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chuphuongtien")]
    public partial class chuphuongtien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chuphuongtien()
        {
            lichdangkiems = new HashSet<lichdangkiem>();
            phuongtiens = new HashSet<phuongtien>();
        }

        [Key]
        public int maCPT { get; set; }

        [Required]
        [StringLength(100)]
        public string cccd { get; set; }

        [Required]
        [StringLength(100)]
        public string hoVaten { get; set; }

        [Required]
        [StringLength(100)]
        public string soDT { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lichdangkiem> lichdangkiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phuongtien> phuongtiens { get; set; }
    }
}
