using System;
using System.Collections.Generic;

#nullable disable

namespace InstantMapUpdateProject.API.Models
{
    public partial class Courier
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long? IdentityNumber { get; set; }
        public string Phone { get; set; }
        public int? CourierId { get; set; }
    }
}
