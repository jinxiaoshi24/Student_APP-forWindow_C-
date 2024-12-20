namespace GUI.BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diem")]
    public partial class Diem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string mamh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string masv { get; set; }

        public decimal? diemthuongxuyen { get; set; }

        public decimal? diemkt1 { get; set; }

        public decimal? diemkt2 { get; set; }

        public decimal? diemkt3 { get; set; }

        public decimal? diemkt4 { get; set; }

        public decimal? diemkt5 { get; set; }

        public decimal? tbdiemthanhphan { get; set; }

        public decimal? diemthi { get; set; }

        public decimal? diemtongket { get; set; }

        public bool? quamon { get; set; }

        [StringLength(20)]
        public string ghichu { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
