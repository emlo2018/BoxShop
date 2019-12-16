using BoxShop.Models;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoxShop.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            return View(db.ProductTypes.ToList());
        }

        public ActionResult About()
        {
            var db = new ApplicationDbContext();

            return View(db.Products.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Productbycategory(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.Products.Where(p => p.ProductTypeID == id).ToList());
        }


        [HttpPost]
        public ActionResult Cart(string cart)
        {
            List<OrderDetail> orderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(cart);

            ApplicationDbContext db = new ApplicationDbContext();

            List<CartViewModel> viewModel = new List<CartViewModel>();

            foreach (var item in orderDetails)
            {
                Product currentProduct = db.Products.Find(item.ProductId);

                CartViewModel cartItem = new CartViewModel();
                cartItem.Product = currentProduct;
                cartItem.Amount = item.Quantity;

                viewModel.Add(cartItem);
            }


            return View(viewModel);

        }



        [HttpPost]
        [Authorize]
        public ActionResult CreateOrder(string cart)
        {
            List<CreateOrder> CreateOrder = JsonConvert.DeserializeObject<List<CreateOrder>>(cart);

            ApplicationDbContext db = new ApplicationDbContext();

            Order newOrder = new Order();
            newOrder.OrderDate = DateTime.Now;
            newOrder.CustomerId = User.Identity.GetUserId();

            db.Orders.Add(newOrder);
            db.SaveChanges();
            
            


            foreach (var item in CreateOrder)
            {
                Product currentProduct = db.Products.Find(item.ProductId);

                OrderDetail orderRow = new OrderDetail();
                orderRow.OrderId = newOrder.OrderId;
                orderRow.Quantity = item.Quantity;
                orderRow.ProductId = currentProduct.Id;
                orderRow.UnitPrice = currentProduct.Price;

                var subTotal = item.Quantity * currentProduct.Price;

                newOrder.Total += subTotal;

                db.OrderDetails.Add(orderRow);
            }

            db.Entry<Order>(newOrder).State = System.Data.Entity.EntityState.Modified;
           
            db.SaveChanges();


            return View("Thankyou");


        }
    }
}







            