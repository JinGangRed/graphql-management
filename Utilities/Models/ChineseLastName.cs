using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Models
{
    public class ChineseLastName
    {
        public IEnumerable<string> MaleNames { get; set; }
        public IEnumerable<string> FeMaleNames { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        UnKnown
    }

}
