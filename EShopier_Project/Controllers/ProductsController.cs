using System;
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
using static System.Net.WebRequestMethods;
using System.Web.UI.WebControls;

namespace EShopier_Project.Controllers
{
    public class ProductsController : Controller
    {
        ProManager pro = new ProManager();
        private Context db = new Context();

        // GET: Products
        public async Task<ActionResult> Index()
        {
            var products = db.Products.Include(p => p.Brand).Include(p => p.Category);
            return View(await products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public async Task<ActionResult> DetailsForAdmin(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.BrandID = new SelectList(db.Brands, "ID", "Name");
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,UnitPrice,UnitStock,BrandID,CategoryID,AddDate,ProfileImage")] Product product,HttpPostedFileBase ProfileImage)
        {
           
           
            if (ModelState.IsValid)
            {
                if (ProfileImage!=null)
                {
                    var dosyaadi = Path.GetFileName(ProfileImage.FileName);
                    var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);
                    

                    ProfileImage.SaveAs(uzanti);
                    product.ProfileImage = dosyaadi;
                }
                else
                {
                    product.ProfileImage ="productempty.jpg";

                }
                product.AddDate = DateTime.Now;
                db.Products.Add(product); 
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BrandID = new SelectList(db.Brands, "ID", "Name", product.BrandID);
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandID = new SelectList(db.Brands, "ID", "Name", product.BrandID);
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,UnitPrice,UnitStock,BrandID,CategoryID,AddDate,ProfileImage")] Product product, HttpPostedFileBase ProfileImage)
        {
            if (ModelState.IsValid)
            {
                //if (ProfileImage == null)
                //{
                //    pro.FindProduct(product);
                //}
                if(ProfileImage!=null)
                {
                    var dosyaadi = Path.GetFileName(ProfileImage.FileName);
                    var uzanti = Path.Combine(Server.MapPath("~/Content/images"), dosyaadi);

                    ProfileImage.SaveAs(uzanti);
                    product.ProfileImage = dosyaadi;
                }               
                else
                {
                    pro.FindProduct(product);
                    //product.ProfileImage = "productempty.jpg";



                }
                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BrandID = new SelectList(db.Brands, "ID", "Name", product.BrandID);
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Product product = await db.Products.FindAsync(id);
            db.Products.Remove(product);
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
        public ActionResult ProdutDetails()
        {

            return View(pro.Productlist());

        }
        public ActionResult ByBrandForPDetails(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            BrandManager bm = new BrandManager();
            Brand bra = bm.GetBrandgetir(id.Value);

            if (bra == null)
            {
                return HttpNotFound();
            }

            return View("ProdutDetails", bra.Products);
        }
        public ActionResult ByCategoryForPDetails(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            CatManager cm = new CatManager();
            Category cat = cm.GetCategorgetir(id.Value);

            if (cat == null)
            {
                return HttpNotFound();
            }

            return View("ProdutDetails", cat.Product);
        }
    }
}
