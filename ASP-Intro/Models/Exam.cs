using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro.Models
{
    public class Exam
    {
        public Exam(int id, string fullname,int point)
        {
            this.Id = id;
            this.StudentFullName = fullname;
            this.Point = point;
        }
        public int Id { get; set; }
        public string StudentFullName { get; set; }
        public int Point { get; set; }
    }
}
