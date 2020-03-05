namespace WebNhaKhoCuaThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAHANGHOA { get; set; }

        [StringLength(50)]
        public string TENHANGHOA { get; set; }

        [StringLength(50)]
        public string XUATXU { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        public int? SOLUONG { get; set; }
    }
}
