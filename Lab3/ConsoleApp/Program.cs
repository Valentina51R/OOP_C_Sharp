
namespace ConsoleApp
{
    /// <summary>
    /// Основная программа.
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Основная программа.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("\t\tВас приветсвует программа расчёта объёма фогур.");

            while (true)
            {

                Console.Write("Хотите расчитать объём фигуры - введите 1.\n" +
                    "Хотите закончить выполнение программы - введите 2.\nВводите: ");
                bool result = short.TryParse(Console.ReadLine(),
                            out short action);
                if (result != true)
                {
                    Console.WriteLine("Введите число 1 или 2!");
                }

                if (action == 1)
                {
                    ConsoleAddFigure.AddFigure();
                }
                else if (action == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Невозможно понять что вы хотите. \n Введите:");
                }
            }
        }
    }
}