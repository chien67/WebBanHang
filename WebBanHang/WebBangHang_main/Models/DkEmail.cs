namespace WebBangHang_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DkEmail")]
    public partial class DkEmail
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
