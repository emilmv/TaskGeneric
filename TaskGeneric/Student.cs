namespace TaskGeneric
{
    internal class Student
    {
        static int _id;
        public int Id { get; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public byte Age { get; set; }
        public double Point { get; set; }

        public static bool operator >(Student a, Student b)
        {
            return a.Point > b.Point;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Point < b.Point;
        }

        public void showInfo()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("SURNAME: " + Surname);
            Console.WriteLine("AGE: " + Age);
            Console.WriteLine("POINT:" + Point);
        }
        public Student(string name, string surname, double point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
        }

    }
}
