using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105_A.L._6
{
    internal class Classroom
    {
        Student[] students;
        static int _id;
        public int Id;
        public string Name;
        public Typeenum Type;
        public Classroom()
        {
            students = new Student[0];
            Id = ++_id;
        }

        public void StudentAdd(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[^1] = student;
        }
        public Student FindId(int id)
        {
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    student.ShowInfo();
                }
                else
                {
                    throw new Studentdontfoundexception("sagird tapilmadi");
                }
            }
            return null;
        }
        public void RemoveStudent(int id)
        {
            Student[] removestudent = new Student[0];
            int index = 0;
            foreach (Student student in students)
            {
                if (student.Id != id)
                {
                    removestudent[index] = student;
                    index++;
                }
                else
                {
                    throw new Studentdontfoundexception("sagird tapilmadi");
                }

            }
            students = removestudent;
        }
        public void ShowAllInfo()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"id:{student.Id},name:{student.Name}, surname:{student.Surname}");

            }
        }

    }
}
