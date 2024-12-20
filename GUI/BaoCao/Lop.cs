namespace GUI.BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            PhanCongs = new HashSet<PhanCong>();
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [StringLength(5)]
        public string malop { get; set; }

        [StringLength(20)]
        public string tenlop { get; set; }

        [StringLength(5)]
        public string makhoa { get; set; }

        [StringLength(5)]
        public string magv { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
