

using System.Collections;

namespace HashtableQuestion
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

        public static void InsertArrayToHashtable(Student[] student, Hashtable hashtable)
        {
            foreach (Student s in student)
            {
                if (!hashtable.ContainsKey(s.SchoolNumber))
                {
                    hashtable.Add(s.SchoolNumber, s);
                    Console.WriteLine($"Student with school number {s.SchoolNumber} is added");
                }
                else
                {
                    Console.WriteLine($"Sorry, student with the same School Number {s.SchoolNumber} is already exist!");
                }
            }

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
