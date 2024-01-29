namespace ListExamples
{
    class Student
    {
        public string Name;
        public double Grade;
        public string Major;

        public Student(string name, double grade, string major)
        {
            Name = name;
            Grade = grade;
            Major = major;
        }

        public string GetDetails()
        {
            return $"Name: {Name}, Grade: {Grade}, Major: {Major}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> classroom = new List<Student>();
            //I can create like this
            Student student1 = new Student("Goethe",85,"Fine Arts");

            classroom.Add(student1);
            //I also create like this
            classroom.Add(new Student("Picasso",75,"Fine Arts"));
            classroom.Add(new Student("Amie",88,"Social Media"));
            classroom.Add(new Student("Terry",90,"Theather"));
            classroom.Add(new Student("Jerry",100,"Comic"));
            classroom.Add(new Student("Zack",85,"Novel"));
            classroom.Add(new Student("Mozart",95,"Computer Engineering"));
            classroom.Add(new Student("ordinary",30,"Mathematics"));
            classroom.Add(new Student("Charles",65,"Geography"));

            Console.WriteLine(student1.GetDetails());//print from Student Object

            Console.WriteLine(classroom[0].GetDetails());//print from List

            foreach (Student student in classroom)
            {
                Console.WriteLine(student.GetDetails());
            }
            
            Console.WriteLine(classroom.Capacity);
            Console.WriteLine(classroom.Count);

            //LINQ example
            var result =
                from student in classroom
                where student.Grade > 80
                orderby student.Name descending
                select student.Name;

            foreach (var r in result)
            {
                Console.WriteLine(r);//shows grades are greater than 80
            }


        }
    }
}