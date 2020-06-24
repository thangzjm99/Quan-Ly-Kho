namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XUATKHO")]
    public partial class XUATKHO
    {
        [Key]
        public int MAXUATKHO { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYXUATKHO { get; set; }

        public int ID_MAHANGHOA { get; set; }

        public int SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal DONGIA { get; set; }

        [Column(TypeName = "money")]
        public decimal? THANHTIEN { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }
    }
}
