﻿using InstantMapUpdateProject.API.Model;
using InstantMapUpdateProject.API.Models;
using InstantMapUpdateProject.API.Services;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.API.Hubs
{
    public class PharmacyHub : Hub
    {
        private readonly UpdateMapContext _context;

        private readonly PharmacyService _service;
        public PharmacyHub(PharmacyService service, UpdateMapContext context)
        {
            _service = service;
            _context = context;
        }

        public async Task GetLocation(string grupName)//hub üzerinde olduğu için bu metodu invoke etmek gerekiyor
        {
            await Task.Delay(500);//gruba ekleme işlemi gerçekleştikten sonra hemen bu method çalışınca grup oluşmamış oluyor e istek gruptakilere gitmiyor. Bundan dolayı 0.5 sn bekleme süresi koydum

            var setCoordinate = _context.OrderFollowCoordinates.Where(o => o.RoomId == grupName).OrderByDescending(o=>o.Id).Take(1).FirstOrDefault();//en son konumu getir
            await Clients.Group(grupName).SendAsync("serverClient",setCoordinate.courierLatitude,setCoordinate.courierLongitude,setCoordinate.userLatitude,setCoordinate.userLongitude,setCoordinate.centerLatitude,setCoordinate.centerLongitude );

        }

        public async Task addGroup(string grupName)//hub üzerinde olduğu için bu metodu invoke etmek gerekiyor
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, grupName);//connectionid her sayfa yenilendiğinde değişiyor          
        }

        public async Task removeGroup(string id, string grupName)//hub üzerinde olduğu için bu metodu invoke etmek gerekiyor
        {
            await Groups.RemoveFromGroupAsync(id, grupName);
        }


        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync(); 
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }


    }
}
