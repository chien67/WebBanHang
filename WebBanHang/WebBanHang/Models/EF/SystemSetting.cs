using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    public class SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string SettingKey { get; set; }
        [StringLength(5000)]

        public string SettingValue { get; set; }
        [StringLength(5000)]
        public string SettingDescription { get; set; }
    }
}