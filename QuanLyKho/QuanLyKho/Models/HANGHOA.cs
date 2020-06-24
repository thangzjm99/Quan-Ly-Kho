namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHOA()
        {
            NHAPKHOes = new HashSet<NHAPKHO>();
            XUATKHOes = new HashSet<XUATKHO>();
        }

        [Key]
        public int MAHANGHOA { get; set; }

        [Required]
        [StringLength(100)]
        public string TENHANGHOA { get; set; }

        [Required]
        [StringLength(100)]
        public string XUATXU { get; set; }

        [Column(TypeName = "money")]
        public decimal DONGIA { get; set; }

        public int? SOLUONGSANSANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPKHO> NHAPKHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUATKHO> XUATKHOes { get; set; }
    }
}
