//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using StoredProcedure2.Models;
//using StoredProcedure2.ViewModels;
//using AutoMapper;

//namespace StoredProcedure2.Controllers
//{
//    public class Customer1Controller : Controller
//    {
//        private StoredProcedure2Context db = new StoredProcedure2Context();

//        // GET: Customer1
//        public ActionResult Index()
//        {

//            var customerVM = new CustomerViewModel();


//            var customer = db.Customers.ToList();
//            var customerAddress = db.Address.ToList();

//            foreach (var user in customer)
//            {
//                customerVM.Id = user.Id;
//                customerVM.Name = user.Name;
//                customerVM.Email = user.Email;
//            }

//            foreach (var user in customerAddress)
//            {
//                customerVM.StateId = user.StateId;
//                customerVM.CityId = user.CityId;
//            }


//            return View(customerVM);
//        }

//        //// GET: Customer1/Details/5
//        //public ActionResult Details(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
//        //    if (customerViewModel == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(customerViewModel);
//        //}

//        //// GET: Customer1/Create
//        //public ActionResult Create()
//        //{
//        //    return View();
//        //}

//        //// POST: Customer1/Create
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Create([Bind(Include = "Id,Name,Email,Address,StateId,CityId")] CustomerViewModel customerViewModel)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        db.CustomerViewModels.Add(customerViewModel);
//        //        db.SaveChanges();
//        //        return RedirectToAction("Index");
//        //    }

//        //    return View(customerViewModel);
//        //}

//        //// GET: Customer1/Edit/5
//        //public ActionResult Edit(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
//        //    if (customerViewModel == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(customerViewModel);
//        //}

//        //// POST: Customer1/Edit/5
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Edit([Bind(Include = "Id,Name,Email,Address,StateId,CityId")] CustomerViewModel customerViewModel)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        db.Entry(customerViewModel).State = EntityState.Modified;
//        //        db.SaveChanges();
//        //        return RedirectToAction("Index");
//        //    }
//        //    return View(customerViewModel);
//        //}

//        //// GET: Customer1/Delete/5
//        //public ActionResult Delete(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
//        //    if (customerViewModel == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(customerViewModel);
//        //}

//        //// POST: Customer1/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult DeleteConfirmed(int id)
//        //{
//        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
//        //    db.CustomerViewModels.Remove(customerViewModel);
//        //    db.SaveChanges();
//        //    return RedirectToAction("Index");
//        //}

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
