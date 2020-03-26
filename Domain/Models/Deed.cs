using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    [DisplayName("事迹")]
    [Owned]
    public class Deed
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string DeedDescription { get; set; }

    }
}
