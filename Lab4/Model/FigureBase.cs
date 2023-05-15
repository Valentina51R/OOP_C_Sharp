using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Класс для создания
    /// фигуры
    /// </summary>
    [XmlInclude(typeof(Ball))]
    [XmlInclude(typeof(Pyramid))]
    [XmlInclude(typeof(Parallelepiped))]
    public abstract class FigureBase
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        [DisplayName("Тип фигуры")]
        public abstract string FigureType { get; }

        /// <summary>
        /// Метод возвращения параметров фигуры.
        /// </summary>
        [DisplayName("Параметры")]
        public virtual string Parameters { get; }

        /// <summary>
        /// Метод расчёта объёма фигуры.
        /// </summary>
        [DisplayName("Объём, м3")]
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
            else if (double.IsNaN(number))
            {
                throw new ArgumentException("Нечисловое значение!");
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
