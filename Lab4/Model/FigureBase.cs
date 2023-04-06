namespace Model
{
    /// <summary>
    /// Класс для создания
    /// фигуры
    /// </summary>
    public abstract class FigureBase
    {

        /// <summary>
        /// Метод расчёта объёма фигуры.
        /// </summary>
        /// <returns>Volume.</returns>
        public abstract double Volume { get; }

        /// <summary>
        /// Метод проверки введёного числа.
        /// </summary>
        /// <param name="number"></param>
        /// <returns> Число.</returns>
        /// <exception cref="ArgumentException"></exception>
        protected static double CheckNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Метод вывода инфрмации о фигуре.
        /// </summary>
        /// <returns></returns>
        public abstract string GetInfo();


    }
}
