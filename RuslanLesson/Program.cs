namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание неинициализированной переменной
            // int integerValue;
            // Присваивание значения переменной
            // integerValue = 42;

            // Создание и инициализация переменной в одной строке
            int integerValue = 42;
            double doubleValue = 3.14; // Создание и инициализация переменной типа double
            char symbol = '$'; // Создание и инициализация переменной типа char
            string projectName = "RuslanProject"; // Создание и инициализация переменной типа string

            // Вывод значения переменной на консоль
            // Console.WriteLine(integerValue); // Console.WriteLine используется для вывода строки с переносом на новую строку
            // Console.Write(integerValue); // Console.Write используется для вывода строки без переноса на новую строку

            // Целое число: 42.
            Console.WriteLine($"Целое число: {integerValue}."); // Использование интерполяции строк для вывода значения переменной
            Console.WriteLine("Целое число: {0}.", integerValue); // Использование форматированной строки для вывода значения переменной
            Console.WriteLine("Целое число: " + integerValue + "."); // Использование конкатенации строк для вывода значения переменной

            // Типы данных в C#:
            /*
             * int - целое число (от -2,147,483,648 до 2,147,483,647)
             * double - число с плавающей запятой с точностью 15-16 цифр
             * char - символ (один символ, например 'a'). Символы заключаются в одинарные кавычки
             * string - строка (последовательность символов, например "Hello, World!"). Строки заключаются в двойные кавычки
             */

            // Ввод данных с консоли
            Console.Write("\nВведите ваше имя: "); // Вывод приглашения для ввода данных
            string name = Console.ReadLine(); // Чтение строки, введенной пользователем

            Console.Write("Введите ваш возраст: ");
            // int age = Console.ReadLine(); // Ошибка здесь, так как ReadLine возвращает строку, а не int
            // string ageInput = Console.ReadLine();

            // Преобразование строки в целое число
            // 1 способ: использование метода int.Parse
            // int age = int.Parse(ageInput); // Преобразование строки в целое число
            int age = int.Parse(Console.ReadLine()); // Преобразование строки, введенной пользователем, в целое число в одну строку в коде

            // 2 способ: использование метода Convert.ToInt32
            // int age = Convert.ToInt32(Console.ReadLine()); // Преобразование строки, введенной пользователем, в целое число с помощью метода Convert

            Console.WriteLine($"\n\nВаше имя: {name}");
            Console.WriteLine($"Ваш возраст: {age}");
        }
    }
}