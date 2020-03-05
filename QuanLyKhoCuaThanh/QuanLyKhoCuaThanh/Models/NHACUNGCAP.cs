namespace QuanLyKhoCuaThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        public int? MANHACUNGCAP { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TENNHACUNGCAP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SĐT { get; set; }
    }
}
