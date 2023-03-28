
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
        /// <returns>volume.</returns>
        public override double Volume =>
            (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
}
