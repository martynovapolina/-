using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз
{
    public class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Number;
        public string Faculty;
        public string Group;

        public Student() {
            Surname = "Неизвестно";
            Name = "Неизвестно";
            Age = 0;
            Number = "Неизвестно";
            Faculty = "Неизвестно";
            Group = "Неизвестно";
        }

        public Student(string surname, string name, int age, string number, string faculty, string group) {
            Surname = surname;
            Name = name;
            Age = age;
            Number = number;
            Faculty = faculty;
            Group = group;
        }


        public void GetInfo()
        {
            Console.WriteLine($"{Surname} {Name} {Age} {Number} {Faculty} {Group}");
        }
    }
}
