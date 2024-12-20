namespace GUI.BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            Lops = new HashSet<Lop>();
            PhanCongs = new HashSet<PhanCong>();
        }

        [Key]
        [StringLength(5)]
        public string magv { get; set; }

        [StringLength(30)]
        public string hotengv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(3)]
        public string gioitinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [StringLength(20)]
        public string taikhoan { get; set; }

        [StringLength(5)]
        public string makhoa { get; set; }

        public virtual Account Account { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lop> Lops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}
