namespace Model
{
    /// <summary>
    /// Класс параллелепипеда.
    /// </summary>
    public class Parallelepiped : FigureBase
    {
        /// <summary>
        /// Высота.
        /// </summary>
        private double _height;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;

        /// <summary>
        /// Длина.
        /// </summary>
        private double _length;

        /// <summary>
        /// Высота параллелепипеда.
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
        /// Ширина параллелепипеда.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = CheckNumber(value);
            }
        }

        /// <summary>
        /// Длина параллелепипеда.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = CheckNumber(value);
            }
        }

        public override string FigureType
        {
            get
            {
                return $"Параллелепипед";
            }
        }

        public override string Parameters
        {
            get
            {
                return $"{Height} * {Width} * {Length}";
            }
        }

        /// <summary>
        /// Консруктор.
        /// </summary>
        /// <param name="radius"></param>
        public Parallelepiped(double height, double width, double lenght)
        {
            Height = height;
            Width = width;
            Length = lenght;
        }

        public Parallelepiped()
        { }

        /// <summary>
        /// Объём параллелепипеда
        /// </summary>
        public override double Volume
        {
            get
            {
                return Height * Width * Length;
            }
        }

        /// <summary>
        /// Метод вывода инфрмации о фигуре.
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Параллелепипед:" +
                $" {Height} * {Width} * {Length}, V = {Math.Round(Volume, 3)}.";
        }
    }
}
