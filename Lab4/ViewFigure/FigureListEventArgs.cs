using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFigure
{
    internal class FigureListEventArgs : EventArgs
    {
        public BindingList<FigureBase> FigureList { get; private set; }


        public FigureListEventArgs(BindingList<FigureBase> figures)
        {
            FigureList = figures;
        }
    }
}
