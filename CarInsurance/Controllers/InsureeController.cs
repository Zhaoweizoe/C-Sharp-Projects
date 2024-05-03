using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {

            var insurees = db.Insurees.ToList();
            return View(insurees);
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                // Calculate quote
                insurees.Quote = CalculateQuote(insurees);

                // Add the Insuree to the database and save changes.
                db.Insurees.Add(insurees);
                db.SaveChanges();

                // Redirect to the Index action after successful creation.
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return the Create view with the model.
            return View(insurees);
        }

        // Method to calculate insurance quote
        private decimal CalculateQuote(Insurees insurees)
        {
            // Start with a base of $50 / month.
            decimal monthlyTotal = 50;

            // If the user is 18 or under, add $100 to the monthly total.
            if (CalculateAge(insurees.DateOfBirth) <= 18)
            {
                monthlyTotal += 100;
            }
            // If the user is from 19 to 25, add $50 to the monthly total.
            else if (CalculateAge(insurees.DateOfBirth) >= 19 && CalculateAge(insurees.DateOfBirth) <= 25)
            {
                monthlyTotal += 50;
            }
            // If the user is 26 or older, add $25 to the monthly total.
            else
            {
                monthlyTotal += 25;
            }

            // If the car's year is before 2000, add $25 to the monthly total.
            if (insurees.CarYear < 2000)
            {
                monthlyTotal += 25;
            }
            // If the car's year is after 2015, add $25 to the monthly total.
            else if (insurees.CarYear > 2015)
            {
                monthlyTotal += 25;
            }

            // If the car's Make is a Porsche, add $25 to the price.
            if (insurees.CarMake.ToLower() == "porsche")
            {
                monthlyTotal += 25;
                // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                if (insurees.CarModel.ToLower() == "911 carrera")
                {
                    monthlyTotal += 25;
                }
            }

            // Add $10 to the monthly total for every speeding ticket the user has.
            monthlyTotal += insurees.SpeedingTickets * 10;

            // If the user has ever had a DUI, add 25% to the total.
            if (insurees.DUI)
            {
                monthlyTotal *= 1.25m;
            }

        
            // If it's full coverage, add 50% to the total.
         
            if (insurees.CoverageType)
            {
                monthlyTotal *= 1.5m;
            }

            return monthlyTotal;
        }

        // Method to calculate age
        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age -= 1;
            }
            return age;
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees insurees = db.Insurees.Find(id);
            db.Insurees.Remove(insurees);
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
    }
}



