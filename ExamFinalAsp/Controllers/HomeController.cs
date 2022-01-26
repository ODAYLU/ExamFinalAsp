using ExamFinalAsp.Models;
using ExamFinalAsp.Models.ViewModel;
using FileUploadControl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExamFinalAsp.Controllers
{
    public class HomeController : Controller
    {
        private HRDbContext _context;
        private UploadInterface _upload;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, HRDbContext context, UploadInterface upload)
        {
            _logger = logger;
            _context = context;
            _upload = upload;
        }

        public IActionResult Index()
        {
            var data = _context.Cars.ToList();
            return View(data);
        }
        public IActionResult CompanyView()
        {
            ViewBag.Cars = _context.Cars.ToList();
            var data = _context.Companyes.ToList();
            return View(data);
        }
        public IActionResult CreateCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCompany(List<IFormFile> files,CompanyViewModel Cmvm ,Company company)
        {
            string path = string.Empty;
            company.Id = Cmvm.Id;
            company.CName = Cmvm.CName;
            company.Description = Cmvm.Description;
            foreach (var item in files)
            {
                path = Path.GetFileName(item.FileName.Trim());
                company.Logo = "~/uploads/" + path;
            }
            _upload.uploadfilemultiple(files);
            _context.Companyes.Add(company);
            _context.SaveChanges();
            ViewBag.Companyes = _context.Companyes.ToList();
            return RedirectToAction("CreateCompany");
           
        }
        public IActionResult Create()
        {
            ViewBag.Companyes = _context.Companyes.ToList();
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(List<IFormFile> files,CarViewModel vmCar,CarDetails Car )
        {
            string path = string.Empty;
            Car.Id = vmCar.Id;
            Car.CarName = vmCar.CarName;
            Car.Price = vmCar.Price;
            foreach (var item in files)
            {
                path = Path.GetFileName(item.FileName.Trim());
                Car.CarImage = "~/uploads/" + path;
            }
            _upload.uploadfilemultiple(files);
            _context.Cars.Add(Car);
            _context.SaveChanges();
            ViewBag.Companyes = _context.Companyes.ToList();
            return RedirectToAction("Create");
        }
        public IActionResult Details(int id)
        {
            var data = _context.Cars.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        public IActionResult Edit(int id)
        {
            var data = _context.Cars.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(List<IFormFile> files,CarDetails car)
        {
            string path = string.Empty;
            if (ModelState.IsValid)
            {
                foreach (var item in files)
                {
                    path = Path.GetFileName(item.FileName.Trim());
                    car.CarImage = "~/uploads/" + path;
                }
                _upload.uploadfilemultiple(files);
                _context.Cars.Update(car);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("Edit", car);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
