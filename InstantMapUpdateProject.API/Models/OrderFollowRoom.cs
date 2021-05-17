using System;
using System.Collections.Generic;

#nullable disable

namespace InstantMapUpdateProject.API.Models
{
    public partial class OrderFollowRoom
    {
        public byte Id { get; set; }
        public long? OrderNo { get; set; }
        public long? PatientId { get; set; }
        public string RoomId { get; set; }
    }
}
