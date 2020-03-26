using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    [DisplayName("国家")]
    [Owned]
    public class Country
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Continent { get; set; }
    }
}
