namespace ClassroomDatabaseEFCoreLab
{
    public class Program
    {
        static void Main()
        {
            CreateDB();
            DisplayStudentDB();

            //In your program file, create a method called CreateDB. 
            //This should create 1 new student for everyone in the class. 
            //Add their name, favorite food and hometown to the student.
            //Once all students have been added, save the changes to the DB.
            //Run this method once, then comment it out. We only want it to fill the db
            static void CreateDB()
            {
                using (var context = new ClassContext())
                {
                    var allStudents = context.Students.ToList();

                    //Extra credit
                    //Make your code run CreateDB if the database is empty
                    if (allStudents.Count == 0)
                    {
                        var students = new List<Student> {
                         new Student { Name = "Troy", Food = "Pizza", Hometown = "Detroit" },
                         new Student { Name = "Tom", Food = "Steak", Hometown = "Coral" },
                         new Student { Name = "Jude", Food = "Chicken", Hometown = "Grand Rapids" },
                        };

                        foreach (var student in students)
                        {
                            context.Students.Add(student);
                        }
                        context.SaveChanges();
                    }
                }
            }

            //Create another method called DisplayAllDB
            //Loop through all of the students and display their StudentId and their name
            static void DisplayAllDB()
            {
                using (var context = new ClassContext())
                {
                    foreach (var student in context.Students)
                    {
                        Console.WriteLine(value: $"Id: {student.StudentId} Name: {student.Name}");
                    }
                }
            }

            //Create another method called DisplayStudentDB
            //Ask for the user to pick a studentId.
            //Use Linq to grab the right student.
            //Display the students favorite food and their hometown
            static void DisplayStudentDB()
            {
                do
                {
                    DisplayAllDB();
                    Console.Write("Please enter the ID of a student you would like to know more about: ");
                    string userInput = Console.ReadLine();
                    using (var context = new ClassContext())
                    {
                        if (int.TryParse(userInput, out int index))
                        {
                            try
                            {
                                Console.Clear();
                                Student student = context.Students.Where(s => s.StudentId == index).First();
                                Console.WriteLine($"Name: {student.Name}\nFavorite food: {student.Food}\nHometown:{student.Hometown}");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine($"Sorry {index} is not a valid Id.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Sorry {userInput} is not valid input");
                        }
                    }
                } while (Validator.Continue());
            }
        }
    }
}