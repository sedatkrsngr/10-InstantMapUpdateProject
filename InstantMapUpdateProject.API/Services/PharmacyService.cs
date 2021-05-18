using InstantMapUpdateProject.API.Hubs;
using InstantMapUpdateProject.API.Model;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.API.Services
{
    public class PharmacyService
    {
        private readonly IHubContext<PharmacyHub> _hubContext;

        public PharmacyService(IHubContext<PharmacyHub> hubContext)
        {
            _hubContext = hubContext;
        }
        public async Task GetLocation(decimal? courierLati,decimal? courierLongi,string roomId)//buradaki ile pharmacyhıbdaki aynı isimli ama birbirleri ile alakasız. Sadece aynı işlemi yapıyorlar diye. Biri apiden biri serverdan tetikleniyor
        {
            //kaydetme işlemleri-> sonra çağırma
            //await Task.Delay(200);  //grup invoke işlemi oluştuğu için gereksiz.
            await _hubContext.Clients.Group(roomId).SendAsync("apiClient", courierLati, courierLongi);//tüm dinleyenlere son konumu göster
           

        }
        
        
        //public CourierLocation GetCourierLocation()
        //{
        //    Random random = new Random();
        //    int sayi = random.Next(0, 8);


        //    List<CourierLocation> couriers = new List<CourierLocation>() {
        //     new CourierLocation()            {
        //        couriers.Latitude = 48.009041,
        //        longitude =28.914083
        //    },
        //      new CourierLocation()            {
        //        latitude = 41.008041,
        //        longitude =28.914083
        //    },
        //        new CourierLocation()            {
        //        latitude = 51.007041,
        //        longitude =28.914083
        //    },
        //           new CourierLocation()            {
        //        latitude = 41.006041,
        //        longitude =28.914083
        //    },
        //      new CourierLocation()            {
        //        latitude = 41.005041,
        //        longitude =28.914083
        //    },
        //        new CourierLocation()            {
        //        latitude = 41.004041,
        //        longitude =28.914083
        //    },
        //           new CourierLocation()            {
        //        latitude = 41.003041,
        //        longitude =28.914083
        //    },
        //      new CourierLocation()            {
        //        latitude = 41.002041,
        //        longitude =28.914083
        //    },
        //        new CourierLocation()            {
        //        latitude = 41.001041,
        //        longitude =28.914083
        //    }

        //};

        //    double lati = couriers[sayi].latitude;
        //    double longi = couriers[sayi].longitude;


        //    CourierLocation courier = new CourierLocation()
        //    {
        //        latitude = lati,
        //        longitude = longi
        //    };
        //    return courier;
        //}
    }
}
