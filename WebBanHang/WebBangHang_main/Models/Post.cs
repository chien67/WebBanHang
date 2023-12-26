namespace WebBangHang_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public int? CategoryId { get; set; }

        public string Description { get; set; }

        public string Detail { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        [StringLength(550)]
        public string SeoDescription { get; set; }

        [StringLength(250)]
        public string SeoKeywords { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(150)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(150)]
        public string ModifierBy { get; set; }
    }
}
