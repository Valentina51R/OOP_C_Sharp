
namespace Model
{
    //TODO: XML (+)
    /// <summary>
    /// Метод шара.
    /// </summary>
    public class Ball : FigureBase
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Радиус шара.
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = CheckNumber(value);
            }
        }


        /// <summary>
        /// Расчёт объёма шара
        /// </summary>
        /// <returns>valume.</returns>
        public override double Volume
        {
            get
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
            }
        }
    }
}
