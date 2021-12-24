using BLL.Interfaces;
using DAL.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KnowledgeTestingSystem.Controllers
{
    public class AnswersController : Controller
    {
        private readonly IAnswersService _answersService;

        public AnswersController(IAnswersService answersService)
        {
            _answersService = answersService;
        }

        // GET: Answer\Create
        public ActionResult Create(int questionId)
        {
            ViewData["id"] = questionId;
            return View(new Answer());
        }

        // POST: Answer\Create
        [HttpPost]
        public async Task<ActionResult> Create(Answer answer, int questionId)
        {
            try
            {
                await _answersService.CreateAsync(answer);
                return RedirectToAction("Details", "Questions", new { Id = questionId });
            }
            catch
            {
                return View(new Answer());
            }
        }

        // GET: Answer\Delete
        public async Task<ActionResult> Delete(int id, int questionId)
        {
            ViewData["id"] = questionId;
            return View(await _answersService.GetByIdAsync(id));
        }

        // POST: Answer\Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Answer answer, int questionId)
        {
            try
            {
                await _answersService.DeleteAsync(id);
                return RedirectToAction("Details", "Questions", new { Id = questionId });
            }
            catch
            {
                return View(new Answer());
            }
        }
    }
}