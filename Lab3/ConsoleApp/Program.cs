
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
            Console.WriteLine("\t\tВас приветсвует программа расчёта объёма фигур.\n");

            while (true)
            {

                Console.Write("Хотите расчитать объём фигуры - введите 1.\n" +
                    "Хотите закончить выполнение программы - введите 2.\nВведите: ");
                //TODO: rename (+)
                bool isParsed = short.TryParse(Console.ReadLine(),
                            out short actionNumber);
                if (isParsed != true)
                {
                    Console.WriteLine("Невозможно понять что вы хотите.");
                }
                //TODO: switch-case (+)
                switch (actionNumber)
                {
                    case 1:
                        {
                            ConsoleAddFigure.AddFigure();
                            break;
                        }
                    case 2:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Введите число 1 или 2!");
                            break;
                        }
                };
            }
        }
    }
}
