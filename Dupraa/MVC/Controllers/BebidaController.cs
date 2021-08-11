using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class BebidaController : BaseController<Bebidas,BebidasRepository>
    {
        public BebidaController(){}
    }
}