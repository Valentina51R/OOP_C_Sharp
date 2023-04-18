using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFigure
{
    /// <summary>
    /// Класс проверок вводимого числа.
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Метод позволяющий вводить только
        /// числа, запятые и точки.
        /// Использование BackSpace.
        /// </summary>
        /// <param name="e"></param>
        public static void CheckInput(KeyPressEventArgs e)
        {
            //цифры, клавиша BackSpace и запятая а ASCII
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58)
                && number != 8
                && number != 44
                && number != 46)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Преобразование числа в double.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }
            return double.Parse(number);
        }
    }
}
