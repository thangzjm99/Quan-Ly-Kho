namespace WebNhaKhoCuaThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAPKHO")]
    public partial class NHAPKHO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MANHAPKHO { get; set; }

        [StringLength(50)]
        public string TENHANGHOA { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        [Column(TypeName = "money")]
        public decimal? THANHTIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHAPKHO { get; set; }
    }
}
