using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework1.Models;

namespace EntityFramework1
{
    class Program
    {
        static void Main1(string[] args)
        {
            var studentList = new List<Student>()
            {
                new Student {Studnr = 1001, Birthdate = new DateTime(2000,5,18), Name = "Bart"},
                new Student {Studnr = 1002, Birthdate = new DateTime(1997,2,14), Name = "Suzanne"},
                new Student {Studnr = 1003, Birthdate = new DateTime(1999,8,26), Name = "Sam"},
                new Student {Studnr = 1004, Birthdate = new DateTime(2001,12,3), Name = "Inge"}
            };

            var selectedStudents = studentList.Where(student => student.Name.StartsWith("S")).ToList();
            selectedStudents.ForEach(s => Console.WriteLine(s.Name));

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            using (var schoolDbContext = new SchoolDbContext())
            {
                schoolDbContext.Students.Add(new Student { Studnr = 1001, Birthdate = new DateTime(2000, 5, 18), Name = "Bart" });

                var studentList = new List<Student>
                {
                    new Student {Studnr = 1002, Birthdate = new DateTime(1997,2,14), Name = "Suzanne"},
                    new Student {Studnr = 1003, Birthdate = new DateTime(1999,8,26), Name = "Sam"},
                    new Student {Studnr = 1004, Birthdate = new DateTime(2001,12,3), Name = "Inge"}
                };
                schoolDbContext.Students.AddRange(studentList);
                schoolDbContext.SaveChanges();

                var selectedStudents = schoolDbContext.Students.Where(student => student.Name.StartsWith("S")).ToList();
                selectedStudents.ForEach(s => Console.WriteLine(s.Name));
            }

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }

        static void Main3(string[] args)
        {
            using (var schoolDbContext = new SchoolDbContext())
            {
                var stud = new Student { Studnr = 1001, Birthdate = new DateTime(2000, 5, 18), Name = "Bart" };
                schoolDbContext.Students.Add(stud);

                var studentList = new List<Student>
                {
                    new Student {Studnr = 1002, Birthdate = new DateTime(1997,2,14), Name = "Suzanne"},
                    new Student {Studnr = 1003, Birthdate = new DateTime(1999,8,26), Name = "Sam"},
                    new Student {Studnr = 1004, Birthdate = new DateTime(2001,12,3), Name = "Inge"}
                };
                schoolDbContext.Students.AddRange(studentList);
                schoolDbContext.SaveChanges();

                var selectedStudents = schoolDbContext.Students.Where(student => student.Name.StartsWith("S")).ToList();
                selectedStudents.ForEach(s => Console.WriteLine(s.Name));
            }

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            using (var schoolDbContext = new SchoolDbContext())
            {
                var selectedStudents = schoolDbContext.Students.Where(student => student.Name.StartsWith("S")).ToList();
                selectedStudents.ForEach(s => Console.WriteLine(s.Name));

                //var studentSam = schoolDbContext.Students.Find(3);
                //var studentSam = schoolDbContext.Students.SingleOrDefault(s=>s.Name.Equals("Sam"));
                //var studentSam = schoolDbContext.Students.Single(s => s.Studnr==1003);
                //studentSam.Name = "Samuel";
                //schoolDbContext.SaveChanges();
            }

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }


 

 


    }
}
