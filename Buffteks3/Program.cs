using System;

namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    //db.Database.EnsureCreated();

                    Student s = new Student()
                    {
                        StudentID = 3,
                        FirstName = "Jeff",
                        LastName = "Babb",
                        PhoneNumber = "123-555-1234",
                        Email = "asdf@asdfa.csd",
                        Role = "Sophomore"
                    };
                    
                    db.Students.Add(s);

                    db.SaveChanges();
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
