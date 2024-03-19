using System.Threading.Channels;

namespace TaskGeneric
{
    internal class Group
    {
        static int _id = 100;
        public string GroupId { get; }
        public Group()
        {
            _id++;
            GroupId = "AP" + _id;
        }

        public void info()
        {
            Console.WriteLine(GroupId);
        }
    }
}
