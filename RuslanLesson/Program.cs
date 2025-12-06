namespace RuslanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Булевый тип данных
            // bool - логический тип данных, который может принимать два значения: true (истина) и false (ложь)
            bool isTrue = true;

            // Операторы сравнения
            // > - больше
            // < - меньше
            // >= - больше или равно
            // <= - меньше или равно
            // == - равно. Не путать с присваиванием (=)!
            // != - не равно

            /*if (условие)
            {
                тело условия
            }*/

            Console.Write("Enter a first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"First number {firstNumber} greater second number {secondNumber}?");

            if (firstNumber > secondNumber)
            {
                
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("First number are equal with second number.");
            }

            Console.WriteLine("End of program.");
        }
    }
}