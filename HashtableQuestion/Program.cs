
using System.Collections;

namespace HashtableQuestion
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            /*
                the task is getting data from array, check if the school numbers are different,when the number is different Add to the hashtable
               otherwise show the error message
                */

            Hashtable studentsTable = new Hashtable(); 

            Student[] studentsArray = new Student[5];

            //new students are added for inserting process
            studentsArray[0] = new Student(101, "ExpectingErrorStudent:)", 45);
            studentsArray[1] = new Student(102, "Cherry", 65);
            studentsArray[2] = new Student(103, "Berna", 80);
            studentsArray[3] = new Student(104, "Zeynep", 65);
            studentsArray[4] = new Student(105, "Piotr", 75);

            //adding first student to studentsTable to check if my condition is working
            studentsTable.Add(studentsArray[0].SchoolNumber, studentsArray[0]);
            studentsTable.Add(studentsArray[3].SchoolNumber, studentsArray[3]);

            Student.InsertArrayToHashtable(studentsArray, studentsTable);//expecting to add new student
            Console.WriteLine("Insertion process is done. Lets see the new array!");

            //run the loop to see new array
            foreach (var student in studentsArray)
            {
                Student.GetStudentDetails(student);
            }
        }

    }
}