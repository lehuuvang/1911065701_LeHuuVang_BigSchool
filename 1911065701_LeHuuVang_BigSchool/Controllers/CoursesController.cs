using _1911065701_LeHuuVang_BigSchool.Models;
using _1911065701_LeHuuVang_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911065701_LeHuuVang_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Category> Categories { get; set; }

        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel();
            {
                Categories = _dbContext.Categories.ToList();
            };
            return View(viewModel);
        }
    }
}