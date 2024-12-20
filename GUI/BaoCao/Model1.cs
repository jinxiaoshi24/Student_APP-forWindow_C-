using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI.BaoCao
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.type_user)
                .IsFixedLength();

            modelBuilder.Entity<Diem>()
                .Property(e => e.mamh)
                .IsFixedLength();

            modelBuilder.Entity<Diem>()
                .Property(e => e.masv)
                .IsFixedLength();

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemthuongxuyen)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemkt1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemkt2)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemkt3)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemkt4)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemkt5)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.tbdiemthanhphan)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemthi)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.diemtongket)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Diem>()
                .Property(e => e.ghichu)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.magv)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.gioitinh)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.sdt)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.makhoa)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.PhanCongs)
                .WithRequired(e => e.GiaoVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.makhoa)
                .IsFixedLength();

            modelBuilder.Entity<Lop>()
                .Property(e => e.malop)
                .IsFixedLength();

            modelBuilder.Entity<Lop>()
                .Property(e => e.makhoa)
                .IsFixedLength();

            modelBuilder.Entity<Lop>()
                .Property(e => e.magv)
                .IsFixedLength();

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.PhanCongs)
                .WithRequired(e => e.Lop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.mamh)
                .IsFixedLength();

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.PhanCongs)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhanCong>()
                .Property(e => e.magv)
                .IsFixedLength();

            modelBuilder.Entity<PhanCong>()
                .Property(e => e.mamh)
                .IsFixedLength();

            modelBuilder.Entity<PhanCong>()
                .Property(e => e.malop)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.masv)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.gioitinh)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.sdt)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.malop)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);
        }
    }
}
