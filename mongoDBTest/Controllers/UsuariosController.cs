using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MongoDB.Bson;
using MongoDB.Driver;
using  Repository;
namespace mongoDBTest.Controllers
{
    public class UsuariosController : Controller
    {
  
        private  readonly UserRepository r=new UserRepository();
        public ActionResult Index()
        {
           
         


            //foreach (var song in cursor)
            //{
            //    Response.Write(song["name"]);
            //}

            return View(r.GetAllUsers());
        }

    }
}
