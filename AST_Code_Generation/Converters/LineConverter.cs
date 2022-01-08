using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    class LineConverter: IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {
            ArtificialLine line_ = (ArtificialLine)parameter;

            return line_;
        }
    }
}


