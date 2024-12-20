namespace GUI.BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            Diems = new HashSet<Diem>();
        }

        [Key]
        [StringLength(5)]
        public string masv { get; set; }

        [StringLength(30)]
        public string hotensv { get; set; }

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
        public string malop { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
