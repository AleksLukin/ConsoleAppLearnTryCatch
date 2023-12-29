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
            Console.Write("Введите номер задачи: ");
            byte number = byte.Parse(Console.ReadLine());

            if (number == 1)
            {
                Person person = new Person();
                person.Output();
            }

            if (number == 2)
            {
                Number number1 = new Number();
                number1.DivideNumber();
            }

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
                string s = Console.ReadLine();
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
            Console.WriteLine("Name is " + this.name);
            Console.WriteLine("Surname is " + this.surname);
            Console.WriteLine("His date of birthday is " + this.dateOfBirthday);
            Console.WriteLine("His height is " + this.height);
            Console.WriteLine("His weight is " + this.weight);
        }
        /// <summary>
        /// Пример программы деления двух чисел с обработкой 2 исключений: деления на ноль и если вместо 
        /// числа введена буква. Создать новый проект и набрать код программы, проверить программу для разных вариантов.
        /// </summary>

    }

    class Number
    {
        public void DivideNumber()
        {
            Console.Write("Введите первое число ");
            string first = Console.ReadLine();
            bool resultOne = int.TryParse(first, out int numberOne);

            Console.Write("Введите второе число ");
            string second = Console.ReadLine();
            bool resultTwo = int.TryParse(second, out int numberTwo);

            if (resultOne == true && resultTwo == true)
            {
                if (numberOne != 0 && numberTwo != 0)
                {
                    Console.WriteLine(numberOne/numberTwo);
                }
                else
                {
                    Console.WriteLine("Одно из чисел равно нулю!");
                }
            }
            if (resultOne == false || resultTwo == false)
            {
                Console.WriteLine("Число не было введено!");
            }
        }
    }
}






//Для того чтобы справиться с возможными ошибочными ситуациями в коде С#, программа обычно делится на блоки трех 
//разных типов:
//блоки try инкапсулируют код, формирующий часть нормальных действий программы, которые потенциально
//могут столкнуться с серьезными ошибочными ситуациями.
//Блоки catch инкапсулируют код, который обрабатывает ошибочные ситуации,
//происходящие //в коде блока try. Это также удобное место для протоколирования ошибок.
//Блоки finally инкапсулируют код, очищающий любые ресурсы или выполняющий другие действия,которые обычно нужно
//выполнить в конце блоков try или catch. Важно понимать, что этот блок выполняется независимо от того,
//сгенерированo исключение или нет.
