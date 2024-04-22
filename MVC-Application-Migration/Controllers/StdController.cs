using Microsoft.AspNetCore.Mvc;
using MVC_Application_Migration.Models;
using MVC_Application_Migration.Data;


namespace MVC_Application_Migration.Controllers
{
    public class StdController : Controller
    {
        Studentregister std = new Studentregister();

        private readonly ILogger<HomeController> _logger;
        StudentDBContext _db;

        public StdController(ILogger<HomeController> logger, StudentDBContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Studentregister std)
        {
            bool res = true;
            if (ModelState.IsValid)
            {
                _db.Add(std);
                _db.SaveChanges();

                if (res)
                {
                    TempData["msg"] = "Add Successfully...";
                }
                else
                {
                    TempData["msg"] = "Record Not Add..";
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditStudent(int Id)
        {
            Studentregister model = _db.REGISTRATION.Find(Id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditStudent(Studentregister std)
        {

            if (ModelState.IsValid)
            {
                _db.Update(std);
                _db.SaveChanges();
                return RedirectToAction("Std_Register");
            }
            return View();
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            if (id != 0)
            {
                Studentregister user = _db.REGISTRATION.Find(id);
                _db.REGISTRATION.Remove(user);
                _db.SaveChanges();
               
            }
              
            return RedirectToAction("Std_Register");
        }

        public IActionResult Std_Register()
        {
            List<Studentregister> std = _db.REGISTRATION.ToList();
            return View(std);
        }
    }
}
