namespace DocTorOnline.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaKham")]
    public partial class CaKham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaKham()
        {
            LichKhams = new HashSet<LichKham>();
        }

        [Key]
        [StringLength(50)]
        public string MaCa { get; set; }

        [StringLength(250)]
        public string TenCa { get; set; }

        public TimeSpan? ThoiGianBD { get; set; }

        public TimeSpan? ThoiGianKT { get; set; }

        public int? SoLuongKham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichKham> LichKhams { get; set; }
    }
}
