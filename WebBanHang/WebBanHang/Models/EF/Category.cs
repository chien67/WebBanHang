using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("Category")]
    public class Category: CommonAbstract
    {
        public Category() 
        {
            this.News = new HashSet<New>();        
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên danh mục không được để trống")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }

        [StringLength(150)]
        public string SeoTitle { get; set; }
        [StringLength(250)]
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public bool IsAvtive { get; set; }
        public ICollection<New> News { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}