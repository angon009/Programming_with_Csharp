using System;
using System.Collections.Generic;
using System.Linq;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ClassTakingDbContext();


            #region Adding Data in Table
            ////Adding data in student table
            //var student = new Student();
            //student.fullName = "Angon Chowdhury";
            //student.address = "Chittagong";
            //student.dateOfBirth = DateTime.Parse("11/10/1996");


            //context.students.Add(student);
            //context.SaveChanges();
            //Console.WriteLine("Done ");


            //var student = new Student();
            //student.fullName = "Chris Nolan";
            //student.address = "Dhaka";
            //student.dateOfBirth = DateTime.Parse("11-10-1992");

            //context.students.Add(student);
            //context.SaveChanges();
            #endregion


            #region Editing data from Table with Primary Key
            ////Editing data from student table
            //var id = 1;
            //var findStudent = context.students.Find(id);
            //findStudent.fullName = "Jack Sparrow";
            //findStudent.address = "Chittagong,Bangladesh";

            //context.SaveChanges();

            //var id = 2;
            //var findStudent = context.students.Find(id);
            //findStudent.address = "Dhaka, Bangladesh";
            //context.SaveChanges();
            //Console.WriteLine("done");
            #endregion


            #region Editing data from Table without Primary Key
            //var student = new Student();

            //var findStudent = context.students.Where(x => x.fullName.Contains("Chris Nolan")).FirstOrDefault();
            //findStudent.fullName = "Leo Caprio";
            //context.SaveChanges();
            //Console.WriteLine("done");

            #endregion


            #region Deleting data from Table
            //var id = 2;
            //var findData = context.students.Find(id);
            //context.students.Remove(findData);
            //context.SaveChanges();
            //Console.WriteLine("Done");
            #endregion

            #region One to Many Relationship Exmaple 01
            ////Creating new Student
            //var newStudent = new Student();
            //newStudent.fullName = "Mika Petrichev";
            //newStudent.address = "Dhaka, Bangladesh";
            //newStudent.dateOfBirth = DateTime.Parse("07-01-2021");

            ////Creating new Course
            //var newCourse = new Course();
            //newCourse.courseFee = 5000;
            //newCourse.courseStartDate = DateTime.Parse("10-15-2021");

            //newCourse.enrolledStudents = new List<Student>();
            //newCourse.enrolledStudents.Add(newStudent);

            //context.courses.Add(newCourse);
            //context.SaveChanges();

            //Console.WriteLine("Done");
            #endregion

            #region One to Many Relationship Exmple 02

            //Creating new student
            var student = new Student();
            student.fullName = "Petr Mitrichev";
            student.address = "Chittagong, Bangladesh";
            student.dateOfBirth = DateTime.Parse("01-01-2001");


            //Creating Course
            var course = new Course();
            course.courseFee = 3000;
            course.courseStartDate = DateTime.Parse("07-03-2021");

            course.enrolledStudents = new List<Student>();
            course.enrolledStudents.Add(student);

            context.courses.Add(course);
            context.SaveChanges();
            
            #endregion

        }
    }
}
