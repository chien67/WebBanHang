namespace WebBangHang_main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemSetting")]
    public partial class SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string SettingKey { get; set; }

        public string SettingValue { get; set; }

        [StringLength(250)]
        public string SettingDescription { get; set; }
    }
}
