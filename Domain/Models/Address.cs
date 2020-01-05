using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Owned]
    public class Address
    {
        [DisplayName("国家")]
        public string Country { get; set; }
        [DisplayName("省份")]
        public string Province { get; set; }
        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("区域")]
        public string Region { get; set; }
        [DisplayName("街道")]
        public string Street { get; set; }
        [DisplayName("详细地址")]
        public string DetailAddress { get; set; }
        public override string ToString() => $"{Country} {Province} {City} {Street}";
        
    }
}
