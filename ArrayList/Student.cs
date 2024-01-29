

namespace Hashtables
{
    public class Student
    {
        public int SchoolNumber { get; set; }
        public string Name { get; set; }
        public float Grade { get; set; }

        public Student(int schoolNumber, string name, float grade)
        {
            SchoolNumber = schoolNumber;
            Name = name;
            Grade = grade;
        }

        public static void GetStudentDetails(Student student)
        {
            try
            {
                Console.WriteLine($"Student number: {student.SchoolNumber}, student Name: {student.Name}, student Grade: {student.Grade}");

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Your student has not register to our university!");
            }
        }
    }
}
