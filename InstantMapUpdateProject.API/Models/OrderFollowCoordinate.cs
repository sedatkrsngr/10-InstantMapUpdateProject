using System;
using System.Collections.Generic;

#nullable disable

namespace InstantMapUpdateProject.API.Models
{
    public partial class OrderFollowCoordinate
    {
        public byte Id { get; set; }
        public string RoomId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? CourierId { get; set; }
    }
}
