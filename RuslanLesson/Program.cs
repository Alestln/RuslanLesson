namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Целочисленное деление
            // int / int = int

            //// Задание 1a
            /*double a = (3 + 5 * (6 + 3) - 8 * 3 + 1) / (21 + 50.0 / (3 + 4 * (1 + 2)));
            Console.WriteLine("Результат 1a = " + a);*/

            // // Задание 1б
            /*double b = ((0.25 - 0.12) * 0.81 + 0.132 - 2.7 / 3.1) / (3.0 / 7.0 + 2.97 * (8.05 - 8.1 * 6.07));
            Console.WriteLine("Результат 1б = " + b);*/

            /*Console.WriteLine("Введите a, b и c:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double res1 = a + b - c * (3 * a * b + a * a) / (b * c) - Math.Pow(c + a * b / (double)c, 2);
            double res2 = (Math.Pow(a * b + 7 * c, 3) - (a * a + b * b + c * c)) / (b - a * c - a * (b + c));

            Console.WriteLine("Результат 2a = " + res1);
            Console.WriteLine("Результат 2б = " + res2);

            double res3 = (a + 1) / (b - c);*/

            /*short a = 12_000;
            sbyte b = (sbyte)a; */// Подпись кровью: мы уверены, что значение a поместится в тип sbyte

            /*short a = 12_000;
            int b = a;*/ // Безопасное преобразование (widening conversion)

            /*short a = -12;
            ushort b = (ushort)a;*/ // Небезопасное преобразование (narrowing conversion)
        }
    }
}