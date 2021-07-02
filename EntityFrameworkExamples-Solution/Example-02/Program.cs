using System;
using System.Linq;

namespace Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DbContextConfiguration();

            #region  Adding Data in Table
            //var teacher1 = new Teacher();
            //teacher1.name = "Alan Turing";
            //teacher1.designation = "Assistant Lecturer";
            //teacher1.joinDate = DateTime.Now;

            //dbContext.teachers.Add(teacher1);
            //dbContext.SaveChanges();


            //var teacher2 = new Teacher();
            //teacher2.name = "Alan Turing";
            //teacher2.designation = "Assistant Lecturer";
            //teacher2.joinDate = DateTime.Now;

            //dbContext.teachers.Add(teacher2);
            //dbContext.SaveChanges();


            //var teacher3 = new Teacher();
            //teacher3.name = "Alan Turing";
            //teacher3.designation = "Assistant Lecturer";
            //teacher3.joinDate = DateTime.Now;

            //dbContext.teachers.Add(teacher3);
            //dbContext.SaveChanges();
            #endregion


            #region Deleting Data from Table
            //var id1 = 2;
            //var findData = dbContext.teachers.Find(id1);
            //dbContext.Remove(findData);
            //dbContext.SaveChanges();

            //var id2 = 3;
            //var findData2 = dbContext.teachers.Find(id2);
            //dbContext.Remove(findData2);
            //dbContext.SaveChanges();
            #endregion


            #region Adding Data in Table

            //var teacher4 = new Teacher();
            //teacher4.name = "James Gosling";
            //teacher4.designation = "Assistant Professor";
            //teacher4.joinDate = DateTime.Parse("11-10-1996");

            //dbContext.teachers.Add(teacher4);
            //dbContext.SaveChanges();


            //var teacher5 = new Teacher();
            //teacher5.name = "Danis Ritchie";
            //teacher5.designation = "Professor";
            //teacher5.joinDate = DateTime.Parse("10-12-1971");

            //dbContext.teachers.Add(teacher5);
            //dbContext.SaveChanges();

            #endregion

             

        }
    }
}
