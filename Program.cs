using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearnTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();
            Console.ReadLine();
        }
    }
    class Person
    {
        private string name;
        private string surname;
        private System.DateTime dateOfBirthday;
        private double height;
        private int weight;

        public Person()
        {
            Console.Write("Имя ");
            name = Console.ReadLine();

            Console.Write("Фамилия ");
            surname = Console.ReadLine();

            try
            {
                Console.Write("Дата рождения ");
                string s = Console.ReadLine();
                dateOfBirthday = Convert.ToDateTime(s);
            }
            catch (FormatException)
            {
                dateOfBirthday = Convert.ToDateTime("01/01/2001");
            }

            Console.Write("Рост ");
            try
            {
                string s = Console.ReadLine(); // надо вводить десятичную запятую!
                height = Convert.ToDouble(s);
            }
            catch (FormatException)
            {
                height = 1.6;
            }
            Console.Write("Вес ");
            try
            {
                string s = Console.ReadLine(); 
                weight = Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                weight = 90;
            }

        }
        public void Output()
        {
            Console.Clear();
            Console.WriteLine("Name is "+ this.name);
            Console.WriteLine("Surname is "+ this.surname);
            Console.WriteLine("His date of birthday is "+ this.dateOfBirthday);
            Console.WriteLine("His height is " + this.height);
            Console.WriteLine("His weight is " + this.weight);
        }
    }
}
