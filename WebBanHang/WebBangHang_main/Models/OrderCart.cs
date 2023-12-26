namespace WebBangHang_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCart")]
    public partial class OrderCart
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(150)]
        public string CustomerName { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public decimal? TotalMoney { get; set; }

        public int? Quality { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(150)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(150)]
        public string ModifierBy { get; set; }
    }
}
