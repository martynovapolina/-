using System;
using System.Collections.Generic;
using System.Linq;

namespace дз
{
    class Program
    {
        static void Main()
        {

            int Menu()
            {
                Console.WriteLine("\n-----------Меню-----------");
                Console.WriteLine("1) Посмотреть базу данных");
                Console.WriteLine("2) Добавить студента");
                Console.WriteLine("3) Удалить студента");
                Console.WriteLine("4) Сортировка по возрасту");
                Console.WriteLine("5) Сортировка по фамилии");
                Console.WriteLine("6) Вывести данные о факультете");
                Console.WriteLine("7) Поиск по возрасту");
                Console.WriteLine("8) Поиск по первой букве фамилии");
                Console.WriteLine();
                Console.WriteLine("Введите число: ");
                int i = int.Parse(Console.ReadLine());

                return i;
            }
            void Watch(List<Student> stu) {
                foreach (Student student in stu)
                {
                    student.GetInfo();
                }
            }
            void AddStudent(List<Student> stud) {
                Console.WriteLine("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите телефон: ");
                string number = Console.ReadLine();
                Console.WriteLine("Введите факультет: ");
                string faculty = Console.ReadLine();
                Console.WriteLine("Введите группу: ");
                string group = Console.ReadLine();

                stud.Add(new Student(surname, name, age, number, faculty, group));

                foreach (Student student in stud)
                {
                    student.GetInfo();
                }
            }
            void DeleteStudent(List<Student> s) {
                Console.WriteLine("Введите данные о студенте:");
                Console.WriteLine("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите телефон: ");
                string number = Console.ReadLine();
                Console.WriteLine("Введите факультет: ");
                string faculty = Console.ReadLine();
                Console.WriteLine("Введите группу: ");
                string group = Console.ReadLine();

                Student student = new Student(surname, name, age, number, faculty, group);
                s.Remove(student);

                foreach (Student student1 in s)
                {
                    student1.GetInfo();
                }

            }
            void AgeSort(List<Student> st) {
                Console.WriteLine("Сортировка по возрасту: ");
                IEnumerable<Student> result = from item in st orderby item.Age select item;

                foreach (Student student in result)
                {
                    student.GetInfo();
                }
            }
            void NameSort(List<Student> stud) {
                Console.WriteLine("Сортировка по фамилии: ");
                IEnumerable<Student> result = from item in stud orderby item.Surname select item;

                foreach (Student student in result)
                {
                    student.GetInfo();
                }
            }
            void SearchGroup(List<Student> stude) {
                Console.WriteLine("Введите факультет: ");
                string faculty = Console.ReadLine();

                int NumberOfStudents =
                    (from item in stude
                    where item.Faculty == faculty
                    select item).Count();
                Console.WriteLine($"На факультете {faculty} учатся {NumberOfStudents} студентов: ");

                IEnumerable<Student> result =
                    from item in stude
                    where item.Faculty == faculty
                    orderby item.Surname
                    select item;

                foreach (Student student in result)
                {
                    student.GetInfo();
                }
            }
            void SearchAge (List<Student> a) {
                Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

                int NumberOfStudents =
                    (from item in a
                     where item.Age == age
                     select item).Count();
                Console.WriteLine($"В университете учатся {NumberOfStudents} студентов возраста {age}: ");

                IEnumerable<Student> result =
                    from item in a
                    where item.Age == age
                    orderby item.Surname
                    select item;

                foreach (Student student in result)
                {
                    student.GetInfo();
                }
            }
            void SearchLetter (List<Student> b) {
                Console.WriteLine("Введите первую букву: ");
                char letter = char.Parse(Console.ReadLine());

                int NumberOfStudents =
                    (from item in b
                     where item.Surname[0] == letter
                     select item).Count();
                Console.WriteLine($"В университете учатся {NumberOfStudents} студентов с фамилией, начинающейся на букву {letter}: ");

                IEnumerable<Student> result =
                    from item in b
                    where item.Surname[0] == letter
                    orderby item.Surname
                    select item;

                foreach (Student student in result)
                {
                    student.GetInfo();
                }
            }

            List<Student> students = new List<Student>();

            students.Add(new Student("Петров", "Аркадий", 19, "89873647546", "ИУ5", "31Б"));
            students.Add(new Student("Иванова", "Алена", 18, "89763546274", "ИУ5", "11Б"));
            students.Add(new Student("Сидоров", "Вячеслав", 19, "89928374659", "ИУ5", "31Б"));
            students.Add(new Student("Мамонтова", "Варвара", 20, "89027364958", "ИУ7", "51Б"));
            students.Add(new Student("Носов", "Евгений", 19, "89187635298", "ИУ8", "31Б"));
            students.Add(new Student("Исаева", "Ангелина", 22, "89060462220", "ИУ8", "71Б"));


            while (true) {
                switch (Menu()) {
                    case 1:
                        {
                            Watch(students);
                            break;

                        }
                    case 2: 
                        {
                            AddStudent(students);
                            break;
                        }
                    case 3:
                        {
                            DeleteStudent(students);
                            break;
                        }
                    case 4:
                        {
                            AgeSort(students);
                            break;
                        }
                    case 5:
                        {
                            NameSort(students);
                            break;
                        }
                    case 6:
                        {
                            SearchGroup(students);
                            break;
                        }
                    case 7:
                        {
                            SearchAge(students);
                            break;
                        }
                    case 8:
                        {
                            SearchLetter(students);
                            break;
                        }
                }                  
            }


        }
    }
}




