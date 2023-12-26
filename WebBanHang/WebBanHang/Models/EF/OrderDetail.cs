using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [Column(Order =0)]
        public int OrderId { get; set; }

        [Column(Order = 1)]
        public int ProductId { get; set; }
        public int Quality { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order{ get; set; }
        public virtual Product Product { get; set; }
    }
}