using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace webDangKiem.Models
{
    public partial class DBContextDangKiem : DbContext
    {
        public DBContextDangKiem()
            : base("name=DBContextDangKiem")
        {
        }

        public virtual DbSet<chuphuongtien> chuphuongtiens { get; set; }
        public virtual DbSet<dangkiemvien> dangkiemviens { get; set; }
        public virtual DbSet<lichdangkiem> lichdangkiems { get; set; }
        public virtual DbSet<phuongtien> phuongtiens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<trungtam> trungtams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chuphuongtien>()
                .Property(e => e.cccd)
                .IsUnicode(false);

            modelBuilder.Entity<chuphuongtien>()
                .Property(e => e.soDT)
                .IsUnicode(false);

            modelBuilder.Entity<chuphuongtien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<chuphuongtien>()
                .HasMany(e => e.lichdangkiems)
                .WithRequired(e => e.chuphuongtien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<chuphuongtien>()
                .HasMany(e => e.phuongtiens)
                .WithRequired(e => e.chuphuongtien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dangkiemvien>()
                .Property(e => e.tenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<dangkiemvien>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<phuongtien>()
                .Property(e => e.bienSoxe)
                .IsUnicode(false);

            modelBuilder.Entity<phuongtien>()
                .HasMany(e => e.lichdangkiems)
                .WithRequired(e => e.phuongtien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<trungtam>()
                .HasMany(e => e.lichdangkiems)
                .WithRequired(e => e.trungtam)
                .WillCascadeOnDelete(false);
        }
    }
}
