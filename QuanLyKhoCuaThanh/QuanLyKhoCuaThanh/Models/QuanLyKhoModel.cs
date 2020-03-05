namespace QuanLyKhoCuaThanh.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKhoModel : DbContext
    {
        public QuanLyKhoModel()
            : base("name=QuanLyKhoModel")
        {
        }

        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHAPKHO> NHAPKHOes { get; set; }
        public virtual DbSet<XUATKHO> XUATKHOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NHAPKHO>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NHAPKHO>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<XUATKHO>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<XUATKHO>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);
        }
    }
}
