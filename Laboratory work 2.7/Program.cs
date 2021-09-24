using System;

namespace Laboratory_work_2._7
{
    enum Position
    {
        Junior, Middle, Senior
    }
    class Employee
    {
        private string name;
        private string surname;
        private Position position;
        private int experience;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public Employee() { }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void CalculateSalary()
        {
            if (position == Position.Junior)
                Console.WriteLine("{0}-year Junior's salary:\n10 000 * {1} * 0.85 = {2} (Tax 15% = {3})",
                    experience, experience, 10000 * experience * 0.85, 10000 * experience / 2 * 0.15);
            else if (position == Position.Middle)
                Console.WriteLine("{0}-year Middle's salary:\n20 000 * {1} * 0.85 = {2} (Tax 15% = {3})",
                    experience, experience, 20000 * experience * 0.85, 20000 * experience / 2 * 0.15);
            else
                Console.WriteLine("{0}-year Senior's salary:\n30 000 * {1} * 0.85 = {2} (Tax 15% = {3})",
                    experience, experience, 30000 * experience * 0.85, 30000 * experience / 2 * 0.15);
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
                Employee e = new Employee("Bill", "Gates");
                e.Position = Position.Senior;
                e.Experience = 10;

                Console.WriteLine("Name: {0}\nSurname: {1}\nPosition: {2}", e.Name, e.Surname, e.Position);
                e.CalculateSalary();

                Console.ReadLine();
            }
        }
    }

