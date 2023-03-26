namespace DocTorOnline.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichKham")]
    public partial class LichKham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichKham()
        {
            PhieuDatLiches = new HashSet<PhieuDatLich>();
        }

        [Key]
        [StringLength(50)]
        public string MaLichKham { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKham { get; set; }

        public int? SoLuongDaDat { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(50)]
        public string MaBS { get; set; }

        [StringLength(50)]
        public string MaCa { get; set; }

        [StringLength(50)]
        public string MaDV { get; set; }

        public virtual BacSi BacSi { get; set; }

        public virtual CaKham CaKham { get; set; }

        public virtual DichVu DichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDatLich> PhieuDatLiches { get; set; }
    }
}
