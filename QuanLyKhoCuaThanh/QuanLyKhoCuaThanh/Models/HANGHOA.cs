namespace QuanLyKhoCuaThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        public int? MAHANGHOA { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TENHANGHOA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string XUATXU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal DONGIA { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOLUONG { get; set; }
    }
}
