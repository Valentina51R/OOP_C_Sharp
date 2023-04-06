
namespace Model
{
    /// <summary>
    /// Класс пирамиды.
    /// </summary>
    public class Pyramid : FigureBase
    {
        /// <summary>
        /// Площадь.
        /// </summary>
        private double _square;

        /// <summary>
        /// Высота.
        /// </summary>
        private double _height;

        /// <summary>
        /// Площадь пирамиды.
        /// </summary>
        public double Square
        {
            get
            {
                return _square;
            }
            set
            {
                _square = CheckNumber(value);
            }
        }

        /// <summary>
        /// Высота пирамиды.
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = CheckNumber(value);
            }
        }

        public Pyramid(double square, double height)
        {
            Square = square;
            Height = height;
        }

        public Pyramid()
        { }

        /// <summary>
        /// Объём пирамиды.
        /// </summary>
        public override double Volume => (1.0 / 3.0) * Square * Height;

        /// <summary>
        /// Метод вывода инфрмации о фигуре.
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Пирамида: H = {Height}, S = {Square}" +
                $", V = {Math.Round(Volume, 3)}.";
        }
    }
}
