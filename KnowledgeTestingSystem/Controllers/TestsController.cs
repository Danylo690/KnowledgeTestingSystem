using BLL.Interfaces;
using DAL.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KnowledgeTestingSystem.Controllers
{
    public class TestsController : Controller
    {
        private readonly ITestsService _testsService;

        public TestsController(ITestsService testsService)
        {
            _testsService = testsService;
        }

        // GET: Test
        public async Task<ActionResult> Index()
        {
            return View(await _testsService.GetAllAsync());
        }

        // GET: Test/Create
        [Authorize(Roles = "Admin")]
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
