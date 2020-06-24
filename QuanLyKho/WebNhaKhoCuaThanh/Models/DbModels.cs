<<<<<<< HEAD:QuanLyKho/WebNhaKhoCuaThanh/Models/DbModels.cs
namespace WebNhaKhoCuaThanh.Models
=======
namespace QuanLyKho.Models
>>>>>>> vietanhreal:QuanLyKho/QuanLyKho/Models/Model1.cs
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

<<<<<<< HEAD:QuanLyKho/WebNhaKhoCuaThanh/Models/DbModels.cs
    public partial class DbModels : DbContext
    {
        public DbModels()
            : base("name=DbModels")
=======
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
>>>>>>> vietanhreal:QuanLyKho/QuanLyKho/Models/Model1.cs
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

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.NHAPKHOes)
                .WithRequired(e => e.HANGHOA)
                .HasForeignKey(e => e.ID_MAHANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.XUATKHOes)
                .WithRequired(e => e.HANGHOA)
                .HasForeignKey(e => e.ID_MAHANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.NHAPKHOes)
                .WithRequired(e => e.NHACUNGCAP)
                .HasForeignKey(e => e.ID_MANHACUNGCAP)
                .WillCascadeOnDelete(false);

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
