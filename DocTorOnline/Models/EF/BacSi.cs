namespace DocTorOnline.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BacSi")]
    public partial class BacSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacSi()
        {
            DanhGias = new HashSet<DanhGia>();
            LichKhams = new HashSet<LichKham>();
        }

        [Key]
        [StringLength(50)]
        public string MaBS { get; set; }

        [StringLength(250)]
        public string TenBS { get; set; }

        [StringLength(100)]
        public string NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string MaKhoa { get; set; }

        [StringLength(50)]
        public string MaCV { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual Khoa Khoa { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGia> DanhGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichKham> LichKhams { get; set; }
    }
}
