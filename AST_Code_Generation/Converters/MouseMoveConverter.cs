using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AST_Code_Generation
{
   public class MouseMoveConverter : IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {          
            MouseData mouseData = new MouseData();
            try
            {
                var args = (MouseEventArgs)value;
              //  var argsSource = (System.Windows.Shapes.Rectangle)args.Source;
      
                var element = (FrameworkElement)parameter;
                var currentPosition = args.GetPosition(element);

                mouseData = new MouseData();
                mouseData.X = currentPosition.X;
                mouseData.Y = currentPosition.Y;

            }
            catch (Exception )
            {
                throw;
            }
            return mouseData;
        }
    }
}
