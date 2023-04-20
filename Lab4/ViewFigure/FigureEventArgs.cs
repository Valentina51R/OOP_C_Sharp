namespace ViewFigure
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FigureEventArgs : EventArgs
    {
        public FigureBase Figure { get; private set; }

        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }
    }
}
