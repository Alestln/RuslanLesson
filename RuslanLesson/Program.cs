namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter a number of weekday (1-7): ");
            int number = int.Parse(Console.ReadLine());*/

            /*switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }*/

            // switch разворачивается в обычные if-else, но более читабельный и удобный для написания.
            /*if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }*/

            // На кубике выпадает число от 1 до 9.
            // Если выпало 1, 8 или 6 - это красный цвет, если 7, 5 или 3 - это желтый цвет, если 9 - это зеленый цвет.

            // int number = Random.Shared.Next(1, 10); // Генерируем случайное число от 1 до 9

            /*if (number == 1 || number == 8 || number == 6)
            {
                Console.WriteLine("Red");
            }
            else if (number == 7 || number == 5 || number == 3)
            {
                Console.WriteLine("Yellow");
            }
            else
            {
                Console.WriteLine("Green");
            }*/

            /*switch (number)
            {
                case 1:
                case 8:
                case 6:
                    Console.WriteLine("Red");
                    break;
                case 7:
                case 5:
                case 4:
                    Console.WriteLine("Yellow");
                    break;
                case 9:
                    Console.WriteLine("Green");
                    break;
                default:
                    Console.WriteLine("Fine");
                    break;
            }*/

            /*switch (number)
            {
                case > 50:
                    Console.WriteLine("Number greater than 50");
                    break;
                case < 50:
                    Console.WriteLine("Number less than 50");
                    break;
            }*/

            /*char symbol = '0';

            switch (symbol)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("Digit");
                    break;
                default:
                    Console.WriteLine("Not a digit");
                    break;
            }*/

            /*string text = "Alex";

            switch (text)
            {
                case "Alex":
                    Console.WriteLine("Hello, Alex!");
                    break;
                case "John":
                    Console.WriteLine("Hello, John!");
                    break;
                default:
                    Console.WriteLine("Hello, stranger!");
                    break;
            }*/

            /*int a = -5;
            int b = 5;

            switch ((a, b))
            {
                case ( > 0, > 0) when a == b:
                    Console.WriteLine($"Both measurements are valid and equal to {a}.");
                    break;

                case ( > 0, > 0):
                    Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
                    break;

                case ( < 0, > 0) when a == -5 && b == 5:
                    Console.WriteLine($"First measurement is not valid, second measurement is {b}.");
                    break;

                default:
                    Console.WriteLine("One or both measurements are not valid.");
                    break;
            }*/

            Console.WriteLine("End of program");

            // Домашнее задание:
            /*
             * Написать калькулятор, используя только switch. 
             * Пользователь вводит два числа и оператор (+, -, *, /), а программа выводит результат.
             */
        }
    }
}