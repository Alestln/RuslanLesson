namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Математические операторы: +, -, *, /, %
            // Присваивание: =, +=, -=, *=, /=, %=
            // Операторы сравнения: ==, !=, >, <, >=, <=. Все операторы сравнения возвращают булево значение (true или false)
            // Логические операторы: && (И), || (ИЛИ), ! (НЕ)

            // int number = Random.Shared.Next(1, 101); // Генерируем случайное число от 1 до 100
            // int number = Random.Shared.Next(51); // Генерируем случайное число от 0 до 50

            // bool isEven = number % 2 == 0; // Проверяем, является ли число четным

            /*if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} является четным.");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечетным.");
            }*/

            // int number = Convert.ToInt32(Console.ReadLine());
            // int number = int.Parse(Console.ReadLine());
            
            // bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            /*if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"Получилось! Число: {number}");
            }
            else
            {
                Console.WriteLine("Не получилось :(");
            }*/
        }
    }
}