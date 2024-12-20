namespace GUI.BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanCong")]
    public partial class PhanCong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string magv { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string mamh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string malop { get; set; }

        public int? namhoc { get; set; }

        public int? hocky { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
