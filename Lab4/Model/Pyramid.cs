
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
            return $"Пирамила с параметрами:" +
                $"высота: {Height}, площадь основания: {Square}" +
                $"\n имеет объём {Volume}.";
        }
    }
}
