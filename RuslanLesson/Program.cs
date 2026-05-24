namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый палец руки (1-5): ");
            int fingerNumber = int.Parse(Console.ReadLine());

            if (fingerNumber == 1)
            {
                Console.WriteLine("Большой палец");
            }
            else if (fingerNumber == 2)
            {
                Console.WriteLine("Указательный палец");
            }
            else if (fingerNumber == 3)
            {
                Console.WriteLine("Средний палец");
            }
            else if (fingerNumber == 4)
            {
                Console.WriteLine("Безымянный палец");
            }
            else if (fingerNumber == 5)
            {
                Console.WriteLine("Мизинец");
            }
            else
            {
                Console.WriteLine("Неверный номер пальца");
            }
        }
    }
}