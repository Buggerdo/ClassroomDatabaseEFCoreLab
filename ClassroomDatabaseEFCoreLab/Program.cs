using System.Xml.Linq;

namespace ClassroomDatabaseEFCoreLab
{
    public class Program
    {
        static void Main()
        {
            //CreateDB();









            static void CreateDB()
            {
                using(var context = new ClassContext())
                {
                    var students = new List<Student> {
                         new Student { Name = "Troy", Food = "Pizza", Hometown = "Detroit" },
                         new Student { Name = "Tom", Food = "Steak", Hometown = "Coral" },
                         new Student { Name = "Jude", Food = "Chicken", Hometown = "Grand Rapids" },
                    };

                    foreach(var student in students)
                    {
                        context.Students.Add(student);
                    }
                    context.SaveChanges();

                    //for demo purposes
                    var allStudents = context.Students.ToList();
                    Console.WriteLine($"Current student count: {allStudents.Count}");
                }
            }
        }
    }
}