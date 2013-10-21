using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StackElmoreFlow.Models;

namespace StackElmoreFlow.Controllers
{
    public class QuestionController : Controller
    {
        QuestionRepository _repository;

        public QuestionController()
        {
            _repository = new QuestionRepository();
        }

        //
        // GET: /Question/

        public ActionResult Index()
        {
            IList<Question> questions = _repository.GetQuestions();

            return View("QuestionView", questions);
        }

    }
}
