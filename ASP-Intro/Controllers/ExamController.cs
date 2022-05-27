using ASP_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro.Controllers
{
    public class ExamController : Controller
    {

        private List<Exam> _exams;
        public ExamController()
        {
            _exams = new List<Exam>
            {
                new Exam(1,"ayten magmin",1),
                new Exam(2,"yusif salak",100)
            };
        }
        public ActionResult Index(int id)
        {
            Exam exam = _exams.Find(x=>x.Id==id);
            ViewBag.ExamId = exam.Id;
            ViewBag.FullName = exam.StudentFullName;
            return View();
        }


        public ActionResult Detail(int id)
        {
            Exam exam = _exams.Find(x => x.Id == id);
            ViewBag.ExamId = exam.StudentFullName;
            ViewBag.Point = exam.Point;
            return View();
        }

    }
}
