using DataTransfer.Models;
using DataTransfer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Note()
        {
            //return RedirectToAction(nameof(About));

            List<Student> students = new List<Student>
            {
                new Student{Id = 1,Name="Ferid", Surname="Mammadov"},
                new Student{Id = 2,Name="Ulvi", Surname="Macidov"}
            };
            //ViewBag.Students = students;
            List<Group> groups = new List<Group>
            {
                new Group{Id = 1,Name="P322"},
                new Group{Id = 2,Name="P333"}
            };
            //return RedirectToAction(nameof(About));
            //ViewBag.Groups=groups;
            HomeVm home = new HomeVm();
            home.Students = students;
            home.Groups = groups;
            return View(home);
        }
    }
}
