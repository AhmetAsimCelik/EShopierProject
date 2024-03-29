﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EShopier.Entities;
using Eshopier.DAL;
using BusinessLogicLayer;
using System.IO;

namespace EShopier_Project.Controllers
{
    public class BrandsController : Controller
    {
        private Context db = new Context();
        BrandManager br = new BrandManager();

        // GET: Brands
        public async Task<ActionResult> Index()
        {
            return View(await db.Brands.ToListAsync());
        }

        // GET: Brands/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = await db.Brands.FindAsync(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // GET: Brands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Origin,AddDate,FoundationYear,Description")] Brand brand,HttpPostedFileBase ProfileImage)
        {
            if (ModelState.IsValid)
            {
                if (ProfileImage != null)
                {
                    var dosyaadi = Path.GetFileName(ProfileImage.FileName);
                    var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);


                    ProfileImage.SaveAs(uzanti);
                    brand.ProfileImage = dosyaadi;
                }
                else
                {
                    brand.ProfileImage = "productempty.jpg";

                }
               
                brand.AddDate = DateTime.Now;
                db.Brands.Add(brand);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(brand);
        }

        // GET: Brands/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = await db.Brands.FindAsync(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // POST: Brands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Origin,AddDate,Description,FoundationYear")] Brand brand, HttpPostedFileBase ProfileImage)
        {
            if (ModelState.IsValid)
            {
                if (ProfileImage != null)
                {
                    var dosyaadi = Path.GetFileName(ProfileImage.FileName);
                    var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);

                    ProfileImage.SaveAs(uzanti);
                    brand.ProfileImage = dosyaadi;
                    
                }
                else
                {
                    br.FindBrand(brand);
                    
                }
                db.Entry(brand).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        // GET: Brands/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = await db.Brands.FindAsync(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // POST: Brands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Brand brand = await db.Brands.FindAsync(id);
            db.Brands.Remove(brand);
            await db.SaveChangesAsync();
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
        public ActionResult BrandDetails()
        {
            return View(br.BrandList());
        }

    }
}
