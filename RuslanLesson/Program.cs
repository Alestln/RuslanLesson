namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop
            // do while loop
            // for loop

            /*while (условие_цикла)
            {
                тело_цикла
            }*/

            /*Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
            Console.WriteLine(11);
            Console.WriteLine(12);
            Console.WriteLine(13);
            Console.WriteLine(14);
            Console.WriteLine(15);*/

            int i = 1;
            int max_limit = 15;
            while (i <= max_limit)
            {
                Console.WriteLine(i);
                i++;
            }

            // Бесконечный цикл
            /*while (true)
            {
                Console.WriteLine("Hello world");
            }*/

            Console.WriteLine("End of program");

            // Домашнее задание:
            // 1. Найдите количество четных цифр четырехзначного числа. (while)
            // 2. С помощью цикла do while попросите пользователя ввести число от 1 до 10.
            // Если пользователь ввел число вне этого диапазона, то программа должна продолжать запрашивать ввод,
            // пока не будет введено корректное число. (do while)
            // Почитать чем отличаются циклы while, do while!
        }
    }
}