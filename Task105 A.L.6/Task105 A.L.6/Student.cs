using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105_A.L._6
{
    internal class Student
    {
        static int _id;
        public int Id;
        public string Name;
        public string Surname;
        public Student()
        {
            Id = ++_id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"id:{Id}, name:{Name}, surname:{Surname}");
        }
    }
}
