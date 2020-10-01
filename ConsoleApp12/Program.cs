
using System;
using System.Collections;
using System.Collections.Generic;

namespace StuAsp
{
    class Program
    {
      static ArrayList list = new ArrayList();
      static LinkedList<Aspirant> list1 = new LinkedList<Aspirant>();

        public static void Main()
        {
         
                Console.WriteLine("нажмите 1 чтобы добавить Студента");
                Console.WriteLine("нажмите 2 чтобы добавить Аспиранта");
                Console.WriteLine("нажмите 3 чтобы узнать информацию о Студентах");
                Console.WriteLine("нажмите 4 чтобы узнать информацию об Аспирантах ");
                Console.WriteLine("нажмите 5 чтобы узнать информацию о студентах и об аспирантах");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        list = AddStu(list);
                    Main();
                        break;
                    case "2":
                        list1 = AddAsp(list1);
                    Main();
                        break;
                    case "3":
                        PrintInfoStu(list);
                        PrintNewInfoStud(list);
                    Main();
                        break;
                    case "4":
                        PrintInfoAsp(list1);
                    Main();
                        break;
                    case "5":
                        PrintAllInfo(list, list1);
                    Main();
                        break;
                    default:
                        break;
                }
            
        }
        static bool CheckNum(string a)
        {
            if (int.TryParse(a, out int b))
                return true;
            else
                return false;
        }
        static bool CheckStr(string a)
        {
            char[] ch = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    if (a[i] == ch[j])
                        return false;
                }
            }
            return true;
        }
        static string CheckName()
        {
            string name = Console.ReadLine();
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] big_eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] big_rus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я' };
            char first = name[0];
            int j = 0;
            for (int i = 0; i < big_eng.Length; i++)

            {
                if (first == big_eng[i])
                {
                    j++;

                    break;
                }

            }

            if (j == 0)
            {
                for (int i = 0; i < big_rus.Length; i++)

                {
                    if (first == big_rus[i])
                    {
                        j++;

                        break;
                    }

                }

            }

            if (j == 0)
            {
                Console.WriteLine(j);
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return name;
            }
            else// j=1;
            {

                for (int k = 1; k < name.Length; k++)
                {
                    char second = name[k];
                    for (int i = 0; i < eng.Length; i++)

                    {

                        if (name[k] == eng[i])
                        {
                            j++;

                            break;
                        }
                    }
                }
                for (int k = 1; k < name.Length; k++)
                {
                    char second = name[k];
                    for (int i = 0; i < rus.Length; i++)

                    {

                        if (name[k] == rus[i])
                        {
                            j++;

                            break;
                        }
                    }
                }
            }
            if (j != name.Length)
            {
                Console.WriteLine(j);
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return name;
            }
            else
            {
                return name;
            }

        }
        static string CheckLastName()
        {
            string lastname = Console.ReadLine();
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] big_eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            char[] big_rus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я' };
            char first = lastname[0];
            int j = 0;
            for (int i = 0; i < big_eng.Length; i++)

            {
                if (first == big_eng[i])
                {
                    j++;

                    break;
                }

            }

            if (j == 0)
            {
                for (int i = 0; i < big_rus.Length; i++)

                {
                    if (first == big_rus[i])
                    {
                        j++;

                        break;
                    }

                }

            }

            if (j == 0)
            {
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return lastname;
            }
            else// j=1;

            {

                for (int k = 1; k < lastname.Length; k++)
                {
                    char second = lastname[k];
                    for (int i = 0; i < eng.Length; i++)

                    {

                        if (lastname[k] == eng[i])
                        {
                            j++;

                            break;
                        }


                    }
                }
                for (int k = 1; k < lastname.Length; k++)
                {
                    char second = lastname[k];
                    for (int i = 0; i < rus.Length; i++)

                    {

                        if (lastname[k] == rus[i])
                        {
                            j++;

                            break;
                        }

                    }
                }
            }
            if (j != lastname.Length)
            {
                Console.WriteLine("Введите правильные данные");
                CheckName();
                return lastname;
            }
            else
            {
                return lastname;
            }

        }
        static int InNum()
        {
            for (; ; )
            {
                string a = Console.ReadLine();
                bool b = CheckNum(a);
                if (b == true)
                {
                    int c = Convert.ToInt32(a);
                    return c;
                }
                else
                    Console.WriteLine("не коректные данные повторите ввод");
            }
        }
        static string InStr()
        {
            for (; ; )
            {
                string a = Console.ReadLine();
                bool b = CheckStr(a);
                if (b == true)
                    return a;
                else
                    Console.Write("не коректные данные повторите ввод:\t");
            }
        }
        static string InZachet()
        {
            for (; ; )
            {
                int a = InNum();
                if (a < 10000000 && a > 99999999)
                {
                    string b = Convert.ToString(a);
                    return b;
                }
                else
                    Console.Write("номер зачетной книжки дожен быть не меньше и не длиннее 8символов");
            }
        }
        public static ArrayList AddStu(ArrayList list)
        {

                Student student = new Student();

                Console.WriteLine("Введите имя студента");
                student.Name = CheckName();
                Console.WriteLine("Введите фамилию студента");
                student.Lastname = CheckLastName();
                Console.WriteLine("Введите курс обучения");
                student.Kurs = InNum();
                Console.WriteLine("Введите номер зачетной книжки");
                student.Zachet = InNum();
                student.Lvl = "Студент";
                list.Add(student);

                Console.WriteLine("чтобы добавить ещё 1 студента нажмите 1");
                Console.WriteLine("чтобы выйти в меню нажмите любую цифру");
                int a = InNum();
                if (a == 1)
                {
                    AddStu(list);
                return list;
                }
                else
                {
                    Main();
                return list;
                }


        }
        public static LinkedList<Aspirant> AddAsp(LinkedList<Aspirant> list1)
        {

         
                Aspirant aspirant = new Aspirant();
                Console.WriteLine("Введите имя аспиранта");
                aspirant.Name = CheckName();
                Console.WriteLine("Введите фамилию аспиранта");
                aspirant.Lastname = CheckLastName();
                Console.WriteLine("Введите курс обучения");
                aspirant.Kurs = InNum();
                Console.WriteLine("Введите номер зачетной книжки");
                aspirant.Zachet = InNum();
                Console.WriteLine("Введите тему дисертации");
                aspirant.Diss = InStr();
                aspirant.Lvl = "Аспирант";
                list1.AddLast(aspirant);

                Console.WriteLine("нажмите 1 чтобы добавить ещё аспиранта");
                Console.WriteLine("Нажмите любую цифру чтобы выйти");
                int a = InNum();
                if (a == 1)
                {
                    AddAsp(list1);
                return list1;
                }
                else
                {
                    Main();
                    return list1;
                }
         
        }
        public static void PrintInfoStu(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

                Student st2 = (Student)list[i];

                Student.PrintInfo(st2);

            }
        }
          public static void PrintNewInfoStud(ArrayList list)
        {

            list.Sort();
            PrintInfoStu(list);
        }
     static void PrintInfoAsp(LinkedList<Aspirant> list1)
        {

            foreach (Aspirant i in list1)
            {
                Console.WriteLine(i);
                Aspirant.PrintInfo(i);
            }
        }
      public static void PrintAllInfo(ArrayList list, LinkedList<Aspirant> list1)
        {
            Dictionary<int, ArrayList> students = new Dictionary<int, ArrayList>(1);
            students.Add(1, list);

            Dictionary<int, LinkedList<Aspirant>> aspirants = new Dictionary<int, LinkedList<Aspirant>>(1);
            aspirants.Add(2, list1);

            foreach(KeyValuePair<int, ArrayList> keyValue in students)
            {
                PrintInfoStu(keyValue.Value);
            }

            foreach (KeyValuePair<int, LinkedList<Aspirant>> keyValue in aspirants)
            {
                PrintInfoAsp(keyValue.Value);
            }

        }
    }

    public abstract class People
    {
        public string Name { get; set; }
        public string Lastname { get; set; }

        public People()
        {

        }

        public People(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

    }
    public class Student : People
    {
        private int kurs;
        public int Kurs { get; set; }
        private int zachet;
        public int Zachet { get; set; }

        private string lvl;
        public string Lvl;

        public Student() { }

        public Student(string name, string lastname, int kurs, int zachet, string lvl) : base(name, lastname)
        {

            Kurs = kurs;
            Zachet = zachet;
            Lvl = lvl;

        }


        public static void PrintInfo(Student student)
        {
            Console.WriteLine($"Имя и фамилия студента: {student.Name} {student.Lastname} \n Курс обучения: {student.Kurs} \n Номер зачетной книжки: {student.Zachet}");
            Console.WriteLine("\n");
        }

    }
    class Aspirant : Student
    {
        public Aspirant() { }

        public Aspirant(string name, string lastName, int kurs, int zachet, string diss, int n, string lvl)
            : base(name, lastName, kurs, zachet, lvl)
        {
            Diss = diss;
        }
        public string Diss { get; set; }

        public static new void PrintInfo(Aspirant aspirant)
        {
            Console.WriteLine($"Имя и фамилия аспиранта: {aspirant.Name} {aspirant.Lastname} \n Курс обучения: {aspirant.Kurs} \n Номер зачетной книжки: {aspirant.Zachet} \n Тема дисертации: {aspirant.Diss}");
            Console.WriteLine("\n");

        }
    }

}

