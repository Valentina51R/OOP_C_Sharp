namespace ViewFigure
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Класс событий
    /// </summary>
    public class FigureEventArgs : EventArgs
    {
        /// <summary>
        /// Фигура.
        /// </summary>
        public FigureBase Figure { get; private set; }


        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }

    }
}
