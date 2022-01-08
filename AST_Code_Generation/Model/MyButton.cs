using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AST_Code_Generation
{
    public class MyButton: INotifyPropertyChanged
    {
        private double canvasLeft;
        private double canvasTop;
        private AbstractNode myNode;
        private MyButton b;
        
        public double CanvasLeft
        {
            get { return canvasLeft; }
            set { canvasLeft = value; OnPropertyChanged("CanvasLeft"); }
        }

        public double CanvasTop
        {
            get { return canvasTop; }
            set { canvasTop = value; OnPropertyChanged("CanvasTop"); }
        }

        public AbstractNode MyNode
        {
            get { return myNode; }
            set { myNode = value; OnPropertyChanged("MyNode"); }
        }

        public MyButton B
        {
            get { return b; }
            set { b = value; OnPropertyChanged("B"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
