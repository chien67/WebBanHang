namespace WebBangHang_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Icon { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(150)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(150)]
        public string ModifierBy { get; set; }
    }
}
