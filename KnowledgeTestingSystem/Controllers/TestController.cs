using BLL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeTestingSystem.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestsService _testsService;

        public TestController(ITestsService testsService)
        {
            _testsService = testsService;
        }

        // GET: Test
        public async Task<ActionResult> Index()
        {
            return View(await _testsService.GetAllAsync());
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View(new Test());
        }

        // POST: Test/Create
        [HttpPost]
        public async Task<ActionResult> Create(Test test)
        {
            try
            {
                await _testsService.CreateAsync(test);
                return RedirectToAction("Index", await _testsService.GetAllAsync());
            }
            catch
            {
                return View(new Test());
            }
        }

        // GET: Test/Details
        public async Task<ActionResult> Details(int id)
        {
            return View(await _testsService.GetByIdAsync(id));
        }
    }
}
