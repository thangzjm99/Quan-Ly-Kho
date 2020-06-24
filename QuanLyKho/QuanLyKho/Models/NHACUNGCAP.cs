namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            NHAPKHOes = new HashSet<NHAPKHO>();
        }

        [Key]
        public int MANHACUNGCAP { get; set; }

        [Required]
        [StringLength(100)]
        public string TENNHACUNGCAP { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        public int SĐT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPKHO> NHAPKHOes { get; set; }
    }
}
