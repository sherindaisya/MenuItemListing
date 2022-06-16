using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> Get()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Burger", Active=true, DateOfLaunch=new DateTime(2022,01,01), FreeDelivery=false, Price=350},
                new MenuItem() {Id=2, Name="Pizza", Active=true, DateOfLaunch=new DateTime(2022,02,03), FreeDelivery=true, Price=200},
                new MenuItem() {Id=3, Name="French Fries", Active=false, DateOfLaunch=new DateTime(2022,01,20), FreeDelivery=true, Price=150},
                new MenuItem() {Id=4, Name="Desserts", Active=true, DateOfLaunch=new DateTime(2022,02,23), FreeDelivery=true, Price=400},
                new MenuItem() {Id=5, Name="Drinks", Active=false, DateOfLaunch=new DateTime(2022,01,07), FreeDelivery=true, Price=150},
                new MenuItem() {Id=6, Name="Tea and Coffee", Active=true, DateOfLaunch=new DateTime(2022,04,06), FreeDelivery=true, Price=100}

            };
            return MenuList;
        }


        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Burger", Active=true, DateOfLaunch=new DateTime(2022,01,01), FreeDelivery=false, Price=350},
                new MenuItem() {Id=2, Name="Pizza", Active=true, DateOfLaunch=new DateTime(2022,02,03), FreeDelivery=true, Price=200},
                new MenuItem() {Id=3, Name="French Fries", Active=false, DateOfLaunch=new DateTime(2022,01,20), FreeDelivery=true, Price=150},
                new MenuItem() {Id=4, Name="Desserts", Active=true, DateOfLaunch=new DateTime(2022,02,23), FreeDelivery=true, Price=400},
                new MenuItem() {Id=5, Name="Drinks", Active=false, DateOfLaunch=new DateTime(2022,01,07), FreeDelivery=true, Price=150},
                new MenuItem() {Id=6, Name="Tea and Coffee", Active=true, DateOfLaunch=new DateTime(2022,04,06), FreeDelivery=true, Price=100}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }
    }  
}
