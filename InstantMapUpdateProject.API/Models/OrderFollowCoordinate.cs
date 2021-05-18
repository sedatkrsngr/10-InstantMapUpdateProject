using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InstantMapUpdateProject.API.Models
{
    public partial class OrderFollowCoordinate
    {
        public byte Id { get; set; }
        public string RoomId { get; set; }
        [Column(TypeName = "DECIMAL(9,6)")]
        public decimal? userLatitude { get; set; }
        [Column(TypeName = "DECIMAL(9,6)")]
        public decimal? userLongitude { get; set; }
        [Column(TypeName = "DECIMAL(9,6)")]
        public decimal? courierLatitude { get; set; }
        [Column(TypeName = "DECIMAL(9,6)")]
        public decimal? courierLongitude { get; set; }
        [Column(TypeName = "DECIMAL(9,6)")]
        public decimal? centerLatitude { get; set; }
        [Column(TypeName = "DECIMAL(9,6)")]
        public decimal? centerLongitude { get; set; }
        public int? CourierId { get; set; }
    }
}
