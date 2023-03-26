using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DocTorOnline.Models.EF
{
    public partial class DocTorModel : DbContext
    {
        public DocTorModel()
            : base("name=DocTorModel")
        {
        }

        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<CaKham> CaKhams { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LichKham> LichKhams { get; set; }
        public virtual DbSet<PhieuDatLich> PhieuDatLiches { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacSi>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .Property(e => e.MaCV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaBN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.TenBN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CaKham>()
                .Property(e => e.MaCa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaCV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.MaDanhGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.MaBN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichKham>()
                .Property(e => e.MaLichKham)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichKham>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichKham>()
                .Property(e => e.MaCa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LichKham>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatLich>()
                .Property(e => e.MaPDL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatLich>()
                .Property(e => e.MaBN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatLich>()
                .Property(e => e.MaLichKham)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
