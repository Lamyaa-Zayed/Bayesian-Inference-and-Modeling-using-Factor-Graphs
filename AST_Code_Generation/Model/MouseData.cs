using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AST_Code_Generation
{
    public class MouseData : INotifyPropertyChanged
    {
        private double x;
        private double y;
        private bool isLeftPressed;
        public double X
        {
            get { return x; }
            set { x = value; OnPropertyChanged("X"); }
        }
        
        public double Y
        {
            get { return y; }
            set { y = value; OnPropertyChanged("Y"); }
        }

        private bool isDragged;

        public bool IsDragged
        {
            get { return isDragged; }
            set { isDragged = value; OnPropertyChanged("IsDragged"); }
        }

        public bool IsLeftPressed
        {
            get { return isLeftPressed; }
            set { isLeftPressed = value; OnPropertyChanged("IsLeftPressed"); }
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
