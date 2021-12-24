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
    public class QuestionsController : Controller
    {
        private readonly IQuestionsService _questionsService;

        public QuestionsController(IQuestionsService questionsService)
        {
            _questionsService = questionsService;
        }

        // GET: Question\Create
        public ActionResult Create(int testId)
        {
            ViewData["id"] = testId;
            return View(new Question());
        }

        // POST: Question\Create
        [HttpPost]
        public async Task<ActionResult> Create(Question question, int testId)
        {
            try
            {
                question.TestId = testId;
                await _questionsService.CreateAsync(question);
                return RedirectToAction("Details", "Tests", new { Id = testId });
            }
            catch
            {
                return View(new Question());
            }
        }

        // GET: Question\Details
        public async Task<ActionResult> Details(int id)
        {
            return View(await _questionsService.GetByIdAsync(id));
        }

        // GET: Question\Delete
        public async Task<ActionResult> Delete(int id, int testId)
        {
            ViewData["id"] = testId;
            return View(await _questionsService.GetByIdAsync(id));
        }

        // POST: Question\Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Question question, int testId)
        {
            try
            {
                await _questionsService.DeleteAsync(id);
                return RedirectToAction("Details", "Tests", new { Id = testId });
            }
            catch
            {
                return View(new Question());
            }
        }
    }
}