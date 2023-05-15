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

        /// <summary>
        /// Тип фигуры.
        /// </summary>
        public override string FigureType
        {
            get
            {
                return $"Параллелепипед";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"H = {Height}, W = {Width}, L = {Length}";
            }
        }


        /// <summary>
        /// Конструктор.
        /// </summary>
        public Parallelepiped()
        { }

        /// <summary>
        /// Объём параллелепипеда
        /// </summary>
        public override double Volume
        {
            get
            {
                return CheckNumber(Height * Width * Length);
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
