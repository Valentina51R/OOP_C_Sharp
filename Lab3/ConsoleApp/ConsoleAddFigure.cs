using Model;

namespace ConsoleApp
{
    /// <summary>
    /// Класс добавления параметров фигуры.
    /// </summary>
    public class ConsoleAddFigure
    {
        /// <summary>
        /// Метод проверки ввода числа.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            bool result = double.TryParse(number,
                        out double checkNumber);

            if (result != true)
            {
                throw new ArgumentException("Введите число!");
            }

            return checkNumber;
        }

        /// <summary>
        /// Метод добавления парметров фигуры
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void AddFigure()
        {
            IFigureBase figure = new Ball();

            Action actionStart = new Action(() =>
            {
                Console.Write($"1 - шар,\n" +
                    $"2 - пирамиды,\n3 - параллелепипед." +
                    $"\nРасчёт объёма фигуры:");

                int who = int.Parse(Console.ReadLine());

                switch (who)
                {
                    case 1:
                        {
                            figure = new Ball();
                            break;
                        }

                    case 2:
                        {
                            figure = new Pyramid();
                            break;
                        }
                    case 3:
                        {
                            figure = new Parallelepiped();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Введите корректно.");
                            break;
                        }
                }
            });

            var actionBall = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите радиус шара: ");
                    Ball ball1 = (Ball)figure;

                    ball1.Radius = CheckNumber(Console.ReadLine());

                }), "шар"),
                (new Action(() =>
                {
                    Ball ball1 = (Ball)figure;
                    Console.WriteLine("Объём шара: " + ball1.Volume + "\n");
                    _ = Console.ReadKey();
                }), "шар")
            };

            var actionPyramid = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Pyramid pyramid = (Pyramid)figure;
                    Console.Write("Введите высоту пирамиды: ");

                    pyramid.Height = CheckNumber(Console.ReadLine());

                }), "пирамида"),
                (new Action(() =>
                {
                    Pyramid pyramid = (Pyramid)figure;
                    Console.Write("Введите площадь основания пирамиды: ");

                    pyramid.Square = CheckNumber(Console.ReadLine());

                }), "пирамида"),
                (new Action(() =>
                {
                    Console.WriteLine($"Объём пирамиды: {figure.Volume}" + "\n");
                    _ = Console.ReadKey();

                }), "пирамида")
            };

            var actionParallelepiped = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Parallelepiped parallelepiped = (Parallelepiped)figure;
                    Console.Write("Введите высоту параллелепипеда: ");

                    parallelepiped.Height = CheckNumber(Console.ReadLine());

                }), "Высота параллелепипеда"),
                (new Action(() =>
                {
                    Parallelepiped parallelepiped = (Parallelepiped)figure;
                    Console.Write("Введите ширину параллелепипеда: ");
                    parallelepiped.Width = CheckNumber(Console.ReadLine());


                }), "Ширина параллелепипеда"),
                (new Action(() =>
                {
                    Parallelepiped parallelepiped = (Parallelepiped)figure;
                    Console.Write("Введите длину параллелепипеда: ");
                    parallelepiped.Length = CheckNumber(Console.ReadLine());
                }), "Длина параллелепипеда"),
                (new Action(() =>
                {
                    Console.WriteLine($"Объём параллелепипеда:" +
                        $" {figure.Volume}" + "\n");
                    _ = Console.ReadKey();

                }), "Параллелепипед")
            };

            // Выбор фигуры
            ActionHandler(actionStart, "Фигура");

            switch (figure)
            {
                case Ball:
                    {
                        foreach (var action in actionBall)
                        {
                            ActionHandler(action.Item1, action.Item2);
                        }
                        break;
                    }

                case Pyramid:
                    {
                        foreach (var action in actionPyramid)
                        {
                            ActionHandler(action.Item1, action.Item2);
                        }
                        break;
                    }
                case Parallelepiped:
                    {
                        foreach (var action in actionParallelepiped)
                        {
                            ActionHandler(action.Item1, action.Item2);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// Метод использования Action
        /// </summary>
        /// <param name="action"></param>
        /// <param name="propertyName"></param>
        private static void ActionHandler(Action action, string propertyName)
        {

            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException exception)
                {

                    Console.WriteLine($"Incorrect {propertyName}. " +
                            $"Error: {exception.Message}");

                }
            }
        }
    }
}

