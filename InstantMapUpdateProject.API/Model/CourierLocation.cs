using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.API.Model
{
    public class CourierLocation
    {
        public string RoomId { get; set; }
        public decimal? userLatitude { get; set; }

        public decimal? userLongitude { get; set; }

        public decimal? courierLatitude { get; set; }

        public decimal? courierLongitude { get; set; }

        public decimal? centerLatitude { get; set; }

        public decimal? centerLongitude { get; set; }
        public int? CourierId { get; set; }




       
    }
}
