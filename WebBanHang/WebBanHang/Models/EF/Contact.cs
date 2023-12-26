using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("Contact")]
    public class Contact: CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên không được để trống")]
        [StringLength(150, ErrorMessage ="Không được vượt quá 150 kí tự")]
        public string Name { get; set; }
        public string Website { get; set; }
        [StringLength(150, ErrorMessage = "Không được vượt quá 150 kí tự")]

        public string Email { get; set; }

        [StringLength(maximumLength:4000)]
        public string Message { get; set; }
        public bool isRead { get; set; }
    }
}