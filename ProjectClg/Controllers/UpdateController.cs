using ProjectClg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectClg.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        CollegeDBEntities db = new CollegeDBEntities();
        public ActionResult Update()
        {
            
            return View(db.Proc_GetUpdates().ToList());
        }
        [HttpPost]
        public ActionResult Update(Update u)
        {

            db.Proc_Updates(u.Information, u.CreatedAdmin);
            ModelState.Clear();
            return View(db.Proc_GetUpdates().ToList());
        }
    }
}