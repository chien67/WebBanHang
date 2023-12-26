using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("OrderCart")]
    public class Order: CommonAbstract
    {
        public Order() { 
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public int CustomerName { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public int Address { get; set; }
        public int TotalMoney { get; set; }
        public int Quality { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}