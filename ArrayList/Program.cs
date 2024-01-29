
using System.Collections;

namespace Hashtables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //dictionary has to have two !same! data types as a key - value 
            //hashtable can have two !different! data types as a key - value

            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(101, "Tery", 85);
            Student student2 = new Student(102, "Katie", 95);
            Student student3 = new Student(103, "Jeremy", 75);
            Student student4 = new Student(104, "Kamilla", 90);
            Student student5 = new Student(105, "Ustar", 100);

            //store the data in the hashtable (key-> school number, value-> name and grade)
            studentsTable.Add(student1.SchoolNumber, student1);
            studentsTable.Add(student2.SchoolNumber, student2);
            studentsTable.Add(student3.SchoolNumber, student3);
            studentsTable.Add(student4.SchoolNumber, student4);
            studentsTable.Add(student5.SchoolNumber, student5);

            //now I can call from the hashtable called studentsTable. Just dont forget to cast to the Student object type
            Student storedStudent1 = (Student)studentsTable[1312301];//null object
            Student storedStudent2 = (Student)studentsTable[101];
            Student storedStudent3 = (Student)studentsTable[103];
            Student storedStudent4 = (Student)studentsTable[104];
            Student storedStudent5 = (Student)studentsTable[105];

            
            Student.GetStudentDetails(storedStudent1);
            Student.GetStudentDetails(storedStudent2);
            Student.GetStudentDetails(storedStudent3);
            Student.GetStudentDetails(storedStudent4);
            Student.GetStudentDetails(storedStudent5);

            Console.WriteLine("Foreach with DictionaryEntry variable will start!!");
            //we can use foreach loop and DictionaryEntry in order to retrieve all the data in the hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                //showing that hash table is just a collection of the dictionaryEnties
                //the hash table does not retrieve data in the order in which it was added
                //Student temp = (Student)entry.Value;
                //Student.GetStudentDetails(temp);

                //its not necessary to use temp data. It will work like this
                Student.GetStudentDetails((Student)entry.Value);
            }

            Console.WriteLine("Foreach with Student variable will start!!");
            
            //better way 
            foreach (Student student in studentsTable.Values)
            {
                Student.GetStudentDetails(student);
            }
        }
    }

   

   
}