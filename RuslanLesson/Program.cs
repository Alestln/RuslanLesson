namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Целочисленное деление
            // Пользователю нужно вводить ТОЛЬКО целые числа
            /*int x = 7;
            int y = 2;*/

            // double result = x / y; // Результат будет 3

            // Приведение типов
            // double result = (double)x / y;
            /*double result = x / 2.0;
            Console.WriteLine($"Result is {result}");*/

            // int / int = int
            // double / int = double
            // int / double = double
            // double / double = double

            // Безопасное и не безопасное приведение типов
            /*int x = 100000;
            short y = (short)x;*/ // Не безопасное приведение типов

            /*short x = 30000;
            int y = x;*/ // Безопасное приведение типов

            // Неявное и явное приведение типов
            /*short x = 30000;
            int y = (int)x;*/ // Явное приведение типов

            short x = 30000;
            int y = x; // Неявное приведение типов

            Console.WriteLine($"X: {x}\nY: {y}");

            
        }
    }
}