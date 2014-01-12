using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA3.Models;       // for entity framework
using PagedList;        // for paged list
using PagedList.Mvc;    //

namespace CA3.Controllers
{
    public class HomeController : Controller
    {
        northwndEntities nw = new northwndEntities();
        //
        // GET: /Home/
        

        public ActionResult Index( int? page)   // ? means nullable, we will use this var as a page count
        {                             
            var displayAllProducts = from p in nw.Products
                                     select p;
            //tool tip to display details
            var suppliers = from s in nw.Suppliers
                                          select s;
            //var productsSupplierDetails = from p in nw.Products
            //                              select p.Supplier;
            
            return View(displayAllProducts.OrderBy(p => p.ProductID).ToPagedList(page ?? 1, 6)); ///  paged list : page ?? 1 means if the page number is null, we set it to 1
                                                                                                ///  ,6 means the page will display 6 entries in one page
                                                                                                ///  PagedList also requires a OrderBy or a ToList to start with
        }//end of index

        public PartialViewResult displayOrdersForProduct() 
        {
           
            IEnumerable<Order> model = nw.Orders.Take(3);
           

            return PartialView("displayOrdersForProduct", model); 

        }//end of displayOrdersForProduct

        //public PartialViewResult test(int ? productId)
        //{

        //    var selectedProductId = productId;

        //    var q1 =    from productIdInOrderDetails in nw.Order_Details                    // match the product id from product selected to the one in 
        //                where selectedProductId == productIdInOrderDetails.ProductID        // the order details table and get the order Id
        //                select productIdInOrderDetails.OrderID;

        //    var q2 =    from b in nw.Orders                                                 // match the order id from order details to the one in 
        //                where b.OrderID.ToString() == q1.ToString()                         // the orders table
        //                select b;  // = order id on order table that the product belongs to

        //    //IEnumerable<Order> m = nw.Orders.Where(); 
        //    //IEnumerable<Order> model = nw.Orders.Take(3);

            
        //    return PartialView("displayOrdersForProduct", q2.OrderBy(a=> a.OrderID));

        //}//end of displayOrdersForProduct

        public ActionResult Details(int? id) ///  for testing, enabeled via action link in index view
        {
            var productsSupplierDetails = from p in nw.Products
                                          select p.Supplier;
            return View(productsSupplierDetails);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
