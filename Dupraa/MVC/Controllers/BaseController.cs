using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class BaseController<T,R> : Controller where T : BaseModel where R : BaseRepository<T>
    {
        R repo = Activator.CreateInstance<R>();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(T model)
        {
            repo.Create(model);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repo.Read(id));
        }

        [HttpPost]
        public ActionResult Edit(T model)
        {
            repo.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            return View(repo.Read());
        }
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("List");
        }
    }
}