namespace WebBangHang_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        [StringLength(10)]
        public string ProductId { get; set; }

        public int? Quality { get; set; }

        public decimal? Price { get; set; }
    }
}
