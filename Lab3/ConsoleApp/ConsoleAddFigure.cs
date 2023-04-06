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

            bool isParsed = double.TryParse(number,
                        out double checkNumber);

            if (!isParsed)
            {
                throw new ArgumentException("Введите число!");
            }

            return checkNumber;
        }

        /// <summary>
        /// Метод добавления парметров фигуры.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void AddFigure()
        {
            FigureBase figure = new Ball();

            Action actionStart = new Action(() =>
            {
                Console.Write($"1 - шар,\n" +
                    $"2 - пирамиды,\n3 - параллелепипед." +
                    $"\nРасчёт объёма фигуры:");

                //TODO: rename (+)
                bool isParsed = int.TryParse(Console.ReadLine(), out int what);

                switch (what)
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
                            throw new ArgumentException
                            ("Введите корректный номер фигуры.");
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

                }), "радиуса шара"),
                (new Action(() =>
                {
                    Ball ball1 = (Ball)figure;
                    Console.WriteLine($"Объём шара: " +
                        $"{Math.Round(figure.Volume, 3)}\n");
                    _ = Console.ReadKey();
                }), "объёма шара")
            };

            var actionPyramid = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Pyramid pyramid = (Pyramid)figure;
                    Console.Write("Введите высоту пирамиды: ");
                    pyramid.Height = CheckNumber(Console.ReadLine());

                }), "высоты пирамиды"),
                (new Action(() =>
                {
                    Pyramid pyramid = (Pyramid)figure;
                    Console.Write("Введите площадь основания пирамиды: ");
                    pyramid.Square = CheckNumber(Console.ReadLine());

                }), "площади основания пирамиды"),
                (new Action(() =>
                {
                    Console.WriteLine($"Объём пирамиды: " +
                        $"{Math.Round(figure.Volume, 3)}\n");
                    _ = Console.ReadKey();

                }), "объема пирамиды")
            };

            var actionParallelepiped = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Parallelepiped parallelepiped = (Parallelepiped)figure;
                    Console.Write("Введите высоту параллелепипеда: ");

                    parallelepiped.Height = CheckNumber(Console.ReadLine());

                }), "высоты параллелепипеда"),
                (new Action(() =>
                {
                    Parallelepiped parallelepiped = (Parallelepiped)figure;
                    Console.Write("Введите ширину параллелепипеда: ");
                    parallelepiped.Width = CheckNumber(Console.ReadLine());


                }), "ширины параллелепипеда"),
                (new Action(() =>
                {
                    Parallelepiped parallelepiped = (Parallelepiped)figure;
                    Console.Write("Введите длину параллелепипеда: ");
                    parallelepiped.Length = CheckNumber(Console.ReadLine());
                }), "длинны параллелепипеда"),
                (new Action(() =>
                {
                    Console.WriteLine($"Объём параллелепипеда:" +
                        $" {Math.Round(figure.Volume, 3)}\n");
                    _ = Console.ReadKey();

                }), "объема параллелепипеда")
            };

            // Выбор фигуры
            ActionHandler(actionStart, "номера фигуры");

            var figureActionDictionary = new Dictionary<Type, List<(Action, string)>>
            {
                {typeof(Ball), actionBall },
                {typeof(Pyramid), actionPyramid },
                {typeof(Parallelepiped), actionParallelepiped },
            };

            foreach (var action in figureActionDictionary[figure.GetType()])
            {
                ActionHandler(action.Item1, action.Item2);
            }
        }

        // TODO: соответсвие языков (+)

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

                    Console.WriteLine($"Ошибка при вводе {propertyName}. " +
                            $"Описание ошибки: {exception.Message}");

                }
            }
        }
    }
}

