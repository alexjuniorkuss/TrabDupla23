using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class BaseController<M,R> : Controller where M : BaseModel where R : BaseRepository<M>
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
        public ActionResult Create(M model)
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
        public ActionResult Edit(M model)
        {
            repo.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            return View(repo.Read());
        }
        public ActionResult Create(int id)
        {
            repo.Delete(id);
            return RedirectToAction("List");
        }
    }
}