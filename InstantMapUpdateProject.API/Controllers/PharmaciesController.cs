using InstantMapUpdateProject.API.Model;
using InstantMapUpdateProject.API.Models;
using InstantMapUpdateProject.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmaciesController : ControllerBase
    {
        public UpdateMapContext _context = new UpdateMapContext();
        private readonly PharmacyService _pharmacyService;

        public PharmaciesController(PharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
        }

        [HttpPost]
        public async Task<IActionResult> CourierLastLocation([FromBody]CourierLocation courier)
        {

            await _pharmacyService.GetLocation(courier.courierLatitude, courier.courierLongitude, courier.RoomId);

            OrderFollowCoordinate order = new OrderFollowCoordinate();
            order.courierLatitude = courier.courierLatitude;
            order.courierLongitude = courier.courierLongitude;
            order.userLatitude = courier.userLatitude;
            order.userLongitude = courier.userLongitude;
            order.centerLatitude = courier.centerLatitude;
            order.centerLongitude = courier.centerLongitude;
            order.CourierId = courier.CourierId;
            order.RoomId = courier.RoomId;

            await _context.OrderFollowCoordinates.AddAsync(order);
            await _context.SaveChangesAsync();


            //kullanıcının ve dağıtım adresininin de başlangı. latitude ve longitude değerleri gelmeli
            return Ok(courier);
        }
    }
}
