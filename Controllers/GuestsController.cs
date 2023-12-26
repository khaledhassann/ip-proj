using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class GuestsController : Controller
    {
        private Hotel_IPEntities db = new Hotel_IPEntities();

        // GET: Guests
        public ActionResult Index()
        {
            return View(db.Guests.ToList());
        }

        // GET: Guests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // GET: Guests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cust_id,Fname,Lname,email,password,gender,nationality,address,birthdate,phone_no,points,cardholder_name,card_no,cvv,exp_date")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Guests.Add(guest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guest);
        }

        // GET: Guests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // POST: Guests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cust_id,Fname,Lname,email,password,gender,nationality,address,birthdate,phone_no,points,cardholder_name,card_no,cvv,exp_date")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guest).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guest);
        }

        // GET: Guests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // POST: Guests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Guest guest = db.Guests.Find(id);
            db.Guests.Remove(guest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "email,password")] Guest guest)
        {
            var rec = db.Guests.Where(x => x.email == guest.email && x.password == guest.password).ToList().FirstOrDefault();
            if (rec != null)
            {
                Session["username"] = rec.Fname;
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.error = "Invalid User"; ;
                return View(guest);
            }
        }
        public ActionResult Signup()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Signup([Bind(Include = "Fname,Lname,email,password,gender,nationality,address,birthdate,phone_no")]Guest r)
        {
            if (ModelState.IsValid)
            {

                db.Guests.Add(r);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
                return View(r);
        }
    } 
}
