namespace DocTorOnline.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatLich")]
    public partial class PhieuDatLich
    {
        [Key]
        [StringLength(50)]
        public string MaPDL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        [StringLength(50)]
        public string MaBN { get; set; }

        [StringLength(50)]
        public string MaLichKham { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual LichKham LichKham { get; set; }
    }
}
