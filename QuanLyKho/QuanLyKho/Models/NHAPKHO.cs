namespace QuanLyKho.Models
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
        public int MANHAPKHO { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYNHAPKHO { get; set; }

        public int ID_MAHANGHOA { get; set; }

        public int ID_MANHACUNGCAP { get; set; }

        public int SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal DONGIA { get; set; }

        [Column(TypeName = "money")]
        public decimal? THANHTIEN { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
