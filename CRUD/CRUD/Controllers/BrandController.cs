using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
