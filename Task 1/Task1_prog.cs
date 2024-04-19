using System;

namespace Task1
{
    public class MyAccessModifiers
    {
        private int birthYear;
        protected string personalInfo;
        internal string IdNumber;

        public MyAccessModifiers(int birthYear, string idNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            IdNumber = idNumber;
            this.personalInfo = personalInfo;
        }

        public int Age
        {
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
        }

        public static byte averageMiddleAge = 50;

        public string Name { get; set; }

        public string NickName { get; internal set; }

        public bool HasLivedHalfOfLife()
        {
            return Age >= (MyAccessModifiers.averageMiddleAge / 2);
        }

        public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            if (ReferenceEquals(obj1, obj2))
                return true;
            if (obj1 is null || obj2 is null)
                return false;
            return obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo;
        }

        public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return !(obj1 == obj2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter birth year:");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ID number:");
            string idNumber = Console.ReadLine();

            Console.WriteLine("Enter personal information:");
            string personalInfo = Console.ReadLine();

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter nickname:");
            string nickName = Console.ReadLine();

            MyAccessModifiers person1 = new MyAccessModifiers(birthYear, idNumber, personalInfo);
            person1.Name = name;
            person1.NickName = nickName;
            MyAccessModifiers person2 = new MyAccessModifiers(1998, "235689124578", "Quite good worker");

            Console.WriteLine("Person 1 Name: {0}", person1.Name);
            Console.WriteLine("Person 1 Age: {0}", person1.Age);
            Console.WriteLine("Person 1 Nickname: {0}", person1.NickName);
            Console.WriteLine("Person 1 has lived half of life: {0}", person1.HasLivedHalfOfLife());

            if (person1 == person2)
            {
                Console.WriteLine("Person 1 and Person 2 are equal.");
            }
            else
            {
                Console.WriteLine("Person 1 and Person 2 are not equal.");
            }
        }
    }
}
