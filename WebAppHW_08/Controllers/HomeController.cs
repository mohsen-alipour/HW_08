using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppHW_08.Models;

namespace WebAppHW_08.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PersonRpository _PersonRpository = new PersonRpository();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {
         
            var L_Person = _PersonRpository.GetAllPerson();
            return View(L_Person);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View("Contact");
        }
        public IActionResult Delete(int id)
        {
            
            _PersonRpository.DeletPerson(id);
            return RedirectToAction("index");
           
        }
        public IActionResult layout()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var person=_PersonRpository.Getperson(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(PersonModel item)
        {
            _PersonRpository.DeletPerson(item.Id);        
            _PersonRpository.EditPerson(item);
            return RedirectToAction("index");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}