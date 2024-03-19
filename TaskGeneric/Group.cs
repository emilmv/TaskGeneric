using System.Threading.Channels;

namespace TaskGeneric
{
    internal class Group
    {
        static int _id = 100;
        public string GroupId { get; }
        List<Student> Students { get; set; }








        
        public Group()
        {
            _id++;
            GroupId = "AP" + _id;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void GetAllStudents()
        {
            foreach(Student item in Students)
            {
                Console.WriteLine(item);
            }
        }
        public void Sort()
        {
            List<Student> SortedList = Students;
            SortedList.Sort();
            foreach(Student item in SortedList)
            {
                Console.WriteLine(item);
            }
        }


    }
}
