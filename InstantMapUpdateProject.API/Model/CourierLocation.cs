using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.API.Model
{
    public class CourierLocation
    {
        public string RoomId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? CourierId { get; set; }
    }
}
