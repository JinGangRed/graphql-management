using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    [DisplayName("侠客")]
    public class Valiant:BaseEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string Address { get; set; }

        public string Dybasty { get; set; }

        public string CharacterDescription { get; set; }

        public IEnumerable<Deed> Deeds { get; set; }
    }
}
