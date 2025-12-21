namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter the number: ");
            // int number = int.Parse(Console.ReadLine());
            // int number = Convert.ToInt32(Console.ReadLine());

            /*bool res = int.TryParse(Console.ReadLine(), out int number);

            if (res)
            {
                Console.WriteLine("Data entered correctly.");
            }
            else
            {
                Console.WriteLine("Data entered incorrectly.");
                return;
            }

            Console.WriteLine("End of program.");*/

            // Логические операторы
            // && - и
            // || - или
            // ! - не

            // Console.Write("Enter your age: ");

            // true/false
            // !true => false
            // !false => true

            /*bool result = int.TryParse(Console.ReadLine(), out int age);

            if (!result)
            {
                Console.WriteLine("Data entered incorrectly.");
                return;
            }*/

            /*if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Data entered incorrectly.");
                return;
            }*/

            // Расшифровка ИЛИ
            /*if (age <= 0)
            {
                Console.WriteLine("Age entered incorrectly.");
                return;
            }

            if (age > 123)
            {
                Console.WriteLine("Age entered incorrectly.");
                return;
            }*/

            /*if (age <= 0 || age > 123)
            {
                Console.WriteLine("Age entered incorrectly.");
                return;
            }*/

            // Продать товар можно лицам от 18 до 33 лет включительно

            // Расшифровка И
            /*if (age >= 18)
            {
                if (age <= 33)
                {
                    Console.WriteLine("Sold");
                }
                else
                {
                    Console.WriteLine("Not sold");
                }
            }
            else
            {
                Console.WriteLine("Not sold");
            }*/

            /*if (age >= 18 && age <= 33)
            {
                Console.WriteLine("Sold");
            }
            else
            {
                Console.WriteLine("Not sold");
            }*/

            /*
             * Задача
             * Требуется определить, является ли введенный 
             * пользователем год високосным (напомним, что год является високосным, 
             * если его номер кратен 4, но не кратен 100, а также если он кратен 400).
             */

            Console.Write("Enter the year: ");

            if (!int.TryParse(Console.ReadLine(), out int year) || year < 0)
            {
                Console.WriteLine("Year entered incorrectly.");
                return;
            }

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Leap year.");
            }
            else
            {
                Console.WriteLine("Not a leap year.");
            }
        }
    }
}