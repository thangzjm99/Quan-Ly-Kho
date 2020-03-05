namespace WebNhaKhoCuaThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MANHACUNGCAP { get; set; }

        [StringLength(50)]
        public string TENNHACUNGCAP { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public int? SĐT { get; set; }
    }
}
