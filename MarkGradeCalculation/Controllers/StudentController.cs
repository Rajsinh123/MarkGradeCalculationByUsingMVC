using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarkGradeCalculation.Models;

namespace MarkGradeCalculation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(new StudentMark());
        }
        [HttpPost]
        public ActionResult Index(StudentMark s)
        {
            s.Total = s.Math + s.Science + s.History + s.English;
            s.Percentage = s.Total / 4;

            if (s.Percentage > 35)
            {
                s.Grade  = "passes";
            }
            else
            {
                s.Grade = "fails";
            }
            return View(s);



        }
    }
}