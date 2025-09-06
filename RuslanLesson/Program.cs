namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание переменной с инициализацией
            // тип_данных имя_переменной = значение;

            int number = 5;
            string text = "Hello, World!";
            bool isActive = true;
            double pi = 3.14;

            // Console.WriteLine(pi); // Вывод значения переменной pi

            // Создание переменной без инициализации
            // тип_данных имя_переменной;

            /*int number;
            string text;
            bool isActive;
            double pi;*/

            // Console.WriteLine(pi); // Ошибка: использование неинициализированной переменной

            // Присвоение значения переменной
            // имя_переменной = значение;

            /*number = 5;
            text = "Hello, World!";
            isActive = true;
            pi = 3.14;

            Console.WriteLine(pi);*/ // Теперь переменная инициализирована и готова к использованию

            // Способы вывода информации в консоль
            // Вывести: Число PI равно 3.14

            // 1 способ: Конкатенация (склеивание) строк
            // Console.WriteLine("Число PI равно " + pi);

            // 2 способ: Форматированный вывод
            // Console.WriteLine("Число PI равно {1}", pi);

            // 3 способ: Интерполяция строк (начиная с C# 6.0)
            Console.WriteLine($"Число PI равно {pi}");
        }
    }
}