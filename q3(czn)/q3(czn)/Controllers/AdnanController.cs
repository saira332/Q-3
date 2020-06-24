using q3_czn_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace q3_czn_.Controllers
{
    public class AdnanController : Controller
    {
        // GET: Adnan
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ImageUpload(HttpPostedFileBase file,Image c)
        {
            string realpath = Server.MapPath("/images") + "//" + file.FileName;
            file.SaveAs(realpath);
            c.Image.path = file.FileName;
            _db.SaveChanges();
            return View();
        }

    }
}