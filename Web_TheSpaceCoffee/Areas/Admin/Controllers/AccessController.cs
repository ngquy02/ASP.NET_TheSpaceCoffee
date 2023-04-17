using Microsoft.AspNetCore.Mvc;
using Web_TheSpaceCoffee.Models;

namespace TheSpaceCofffeeAdmin.Controllers
{
    
    public class AccessController : Controller
    {
        QlbanCafeNhom04N04Context db = new QlbanCafeNhom04N04Context();

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]

        public IActionResult Login(TbAdmin user)
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                var u = db.TbAdmins.Where(x => x.Username.Equals(user.Username) &&
                x.Password.Equals(user.Password)).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("Username", u.Username.ToString());
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Login", "Access");
        }


    }
}
