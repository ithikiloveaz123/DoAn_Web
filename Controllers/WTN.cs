using Microsoft.AspNetCore.Mvc;
using DoAn_Web.Models;

namespace DoAn_Web.Controllers
{
    public class WTN : Controller
    {
        DoAnWebContext db = new DoAnWebContext();
        public IActionResult Index()
        {
            var listphong = db.Phongs.ToList();
            return View(listphong);
        }
    }
}
