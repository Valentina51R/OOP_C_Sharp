using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFigure
{
    //TODO: XML
    internal class FigureListEventArgs : EventArgs
    {
        //TODO: XML
        public BindingList<FigureBase> FigureList { get; private set; }

        //TODO: XML
        public FigureListEventArgs(BindingList<FigureBase> figures)
        {
            FigureList = figures;
        }
    }
}
