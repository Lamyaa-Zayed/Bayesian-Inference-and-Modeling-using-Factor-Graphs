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
   public class MouseDownConverter : IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {
            MouseData mouseData = new MouseData();
            AbstractNode node = (AbstractNode)parameter;
            try
            {
                var args = (MouseEventArgs)value;
                //  var argsSource = (System.Windows.Shapes.Rectangle)args.Source;

                containerView v = new containerView();
                var element = (FrameworkElement)v.FindName("grid");
                var currentPosition = args.GetPosition(element);
                mouseData.X = currentPosition.X;
                mouseData.Y = currentPosition.Y;
                mouseData.IsLeftPressed = args.LeftButton == MouseButtonState.Pressed;
                node.Mouse_Data = mouseData;
                //args.MiddleButton;
            }
            catch (Exception )
            {
                throw;
            }
            return node;
        }
    }
}
