using System;
using System.Linq;
using TqlBootcamp.Models;

namespace TqlBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            // use join statement to join student assessment & assessment score


            var _context = new BootcampContext();

            var scores = from s in _context.Students
                         join asc in _context.AssessmentScores
                         on s.Id equals asc.StudentId
                         join a in _context.Assessments
                         on asc.AssessmentId equals a.Id
                         select new { s.Lastname, asc.ActualScore}; 


            foreach(var score in scores)
            {
                Console.WriteLine($"{score.Lastname} {score.ActualScore}");
            }





            //var context = new BootcampContext();
            //var students = context.Students.ToList();


            //var newStudent = new Student()
            //{
            //    Firstname = "Matt",
            //    Lastname = "Sanchez",
            //    TargetSalary = 100000,
            //    InBootcamp = true

            //};
            //context.Students.Add(newStudent);
            //var rowaAffected = context.SaveChanges();


            //var context = new BootcampContext();
            //var assessmentScores = context.AssessmentScores.ToList();


            //var newAssessmentScore = new AssessmentScore()
            //{
            //    ActualScore = 110,
            //    StudentId = 1,
            //    AssessmentId = 5


            //};
            //context.AssessmentScores.Add(newAssessmentScore);
            //var rowaAffected = context.SaveChanges();




            //var context = new BootcampContext();
            //var assessmentScores = context.AssessmentScores.ToList();

            //var tql = context.AssessmentScores.Find(3);
            //context.Remove(tql);
            //var rowsAffected = context.SaveChanges();




            //var _context = new BootcampContext();
            ////add the student
            //var matt = new Student()
            //{
            //    Firstname = "Matt",
            //    Lastname = "Sanchez",
            //    TargetSalary = 100000,
            //    InBootcamp = true
            //};
            ////Add Assessments
            //var git = new Assessment() { Topic = "Git", NumberOfQuestions = 6, MaxPoints = 120 };
            //var sql = new Assessment() { Topic = "SQL", NumberOfQuestions = 12, MaxPoints = 110 };
            //var cs = new Assessment() { Topic = "C#", NumberOfQuestions = 11, MaxPoints = 110 };
            //var js = new Assessment() { Topic = "JavaScript", NumberOfQuestions = 11, MaxPoints = 110 };
            //var ng = new Assessment() { Topic = "Angular", NumberOfQuestions = 11, MaxPoints = 110 };
            //_context.Assessments.AddRange(git, sql, cs, js, ng);
            //if(_context.SaveChanges() ! = 5)  { throw new Exception("Insert assessment failed!"); }
            ////add assessment scores
            //var gitScore = new AssessmentScore()
            //{
            //    StudentId = matt.Id,
            //    AssessmentId = git.Id,
            //    ActualScore = 100
            //};
            //var sqlScore = new AssessmentScore()
            //{
            //    StudentId = matt.Id,
            //    AssessmentId = sql.Id,
            //    ActualScore = 100
            //};
            //var csScore = new AssessmentScore()
            //{
            //    StudentId = matt.Id,
            //    AssessmentId = cs.Id,
            //    ActualScore = 100
            //};
            //var jsScore = new AssessmentScore()
            //{
            //    StudentId = matt.Id,
            //    AssessmentId = js.Id,
            //    ActualScore = 100
            //};
            //var ngScore = new AssessmentScore()
            //{
            //    StudentId = matt.Id,
            //    AssessmentId = ng.Id,
            //    ActualScore = 100
            //};
            //_context.AssessmentScores.AddRange(gitScore, sqlScore);
            //if(_context.SaveChanges() ! = 2) { throw new Exception("Insert assessment Scores Failed!"); }

            //{
            //    var _context = new BootcampContext();
            //    //query context 
            //    var avgPoints = (from asc in _context.AssessmentScores
            //                     select new { asc.ActualScore })
            //        .Average(asc => asc.ActualScore);

            //    //method context
            //    avgPoints = _context.AssessmentScores.Average(asc => asc.ActualScore);

            //    Console.WriteLine($"Average points on assessments is {avgPoints}");
            //}

            //static void LoadDb() { }


            }



        
    }
}
