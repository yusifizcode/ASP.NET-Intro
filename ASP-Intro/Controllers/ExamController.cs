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

        public List<Exam> Exams;
        public ExamController()
        {
            Exams = new List<Exam>
            {
                new Exam(1,"hikmet abbasov",1),
                new Exam(2,"Yusif Osmanov",100)
            };
        }
        public ActionResult Index()
        {
            
            ViewBag.Exams = Exams;
            //ViewBag.FullName = exam.StudentFullName;
            return View();
        }


        public ActionResult Detail(int id)
        {
            Exam exam = Exams.Find(x => x.Id == id);
            ViewBag.FullName = exam.StudentFullName;
            ViewBag.Point = exam.Point;
            return View();
        }

    }
}
