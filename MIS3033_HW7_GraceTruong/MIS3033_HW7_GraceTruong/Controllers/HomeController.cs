﻿using Microsoft.AspNetCore.Mvc;
using MIS3033_HW7_GraceTruong.Data;
using MIS3033_HW7_GraceTruong.Models;

namespace MIS3033_HW7_GraceTruong.Controllers
{
    public class HomeController : Controller
    {
        OrderDB db=new OrderDB();

        public JsonResult EditOrder(string id, int ncogs, int ngears)
        {
            Message msg = new Message();

            Order order = db.Orders.Where(x => x.ID == id).FirstOrDefault();
            
            if(order==null)
            {
                msg.status = "fail";
                msg.message = $"Order ID {id} could not be found in the DB!";

                return Json(msg);
            }

            
            order.nGears = ngears;
            order.nCogs = ncogs;

            order.CalSubtotal();
            order.CalSubtotalLevel();

            //db.Orders.Add(order); not add
            db.SaveChanges();

            msg.status = "success";
            msg.message = "Order edited successfully!";

            return Json(msg);
        }

        public JsonResult AddOrder(string id, int ncogs, int ngears)
        {
            Message msg = new Message();

            Order order = new Order();
            order.ID = id;
            order.nGears = ngears;
            order.nCogs = ncogs;

            order.CalSubtotal();
            order.CalSubtotalLevel();

            db.Orders.Add(order);
            db.SaveChanges();

            msg.status = "success";
            msg.message = "Order added successfully!";

            return Json(msg);
        }


        public JsonResult GetOrders()
        {
            var r=db.Orders;
            return Json(r);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chart()
        {
            return View();  
        }
    }
}
