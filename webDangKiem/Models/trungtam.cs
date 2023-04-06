namespace webDangKiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trungtam")]
    public partial class trungtam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trungtam()
        {
            lichdangkiems = new HashSet<lichdangkiem>();
        }

        [Key]
        public int maTT { get; set; }

        [Required]
        [StringLength(100)]
        public string tenTrungtam { get; set; }

        [Required]
        [StringLength(100)]
        public string diaChi { get; set; }

        [Required]
        [StringLength(100)]
        public string khuVuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lichdangkiem> lichdangkiems { get; set; }
    }
}
