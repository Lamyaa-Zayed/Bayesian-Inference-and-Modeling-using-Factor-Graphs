using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ButtonConverter : IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {
            MyButton button = (MyButton)parameter;

            return button;
        }
    }
}
