namespace TaskGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Marcus","Rashford",10);
            student.Age = 26;
            Student student2 = new Student("Anthony","Martial",9);
            student2.Age = 28;
            Student student3 = new Student("Raphael","Varane",19);
            student3.Age = 30;
            student.showInfo();
            Console.WriteLine("====================================");
            student2.showInfo();
            Console.WriteLine("====================================");
            student3.showInfo();
            Console.WriteLine("====================================");

            Group studentGroup = new Group();
            studentGroup.AddStudent(student);
            studentGroup.AddStudent(student2);
            studentGroup.AddStudent(student3);
            studentGroup.GetAllStudents();
            studentGroup.Sort();

        }
    }
}
