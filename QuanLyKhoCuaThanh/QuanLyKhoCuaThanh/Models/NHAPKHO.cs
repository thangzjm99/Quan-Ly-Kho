namespace QuanLyKhoCuaThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAPKHO")]
    public partial class NHAPKHO
    {
        public int? MANHAPKHO { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TENHANGHOA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOLUONG { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal DONGIA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime NGAYNHAPKHO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal THANHTIEN { get; set; }
    }
}
