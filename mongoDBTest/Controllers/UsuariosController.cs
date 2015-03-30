using System.Web.Mvc;
using  Repository;
namespace mongoDBTest.Controllers
{
    public class UsuariosController : Controller
    {
  
        private  readonly UserRepository r=new UserRepository();
        public ActionResult Index()
        {
            return View(r.GetAllUsers());
        }



        public ActionResult Update(string Id)
        {
        
            return View(r.GetUserById(Id));
        }
    }
}
