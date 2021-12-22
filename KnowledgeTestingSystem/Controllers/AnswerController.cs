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
    public class AnswerController : Controller
    {
        private readonly IAnswersService _answersService;

        public AnswerController(IAnswersService answersService)
        {
            _answersService = answersService;
        }

        // GET: Answer\Create
        public ActionResult Create(int questionId, int testId)
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
                return RedirectToAction("Details", "Question", new { Id = questionId });
            }
            catch
            {
                return View(new Answer());
            }
        }
    }
}