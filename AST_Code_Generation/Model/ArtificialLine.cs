using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AST_Code_Generation
{
    public class ArtificialLine : INotifyPropertyChanged
    {
        public ArtificialLine()
        {
            starting = new MouseData();
            ending = new MouseData();

        }

        private MouseData starting;

        public MouseData Starting
        {
            get { return starting; }
            set { starting = value; OnPropertyChanged("Starting"); }
        }

        private MouseData ending;

        public MouseData Ending 
        {
            get { return ending; }
            set { ending = value; OnPropertyChanged("Ending"); }
        }

        private AbstractNode st_node;

        public AbstractNode St_node
        {
            get { return st_node; }
            set { st_node = value; OnPropertyChanged("St_node"); }
        }

        
        private AbstractNode end_node;

        public AbstractNode End_node
        {
            get { return end_node; }
            set { end_node = value; OnPropertyChanged("End_node"); }
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
