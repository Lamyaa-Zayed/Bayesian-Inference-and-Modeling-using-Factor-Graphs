using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive.Subjects;
using System.Text;
using System.Windows;

namespace AST_Code_Generation
{
    public class NonBinaryNode: INotifyPropertyChanged
    {
        private List<AbstractNode> children;
        private List<AbstractNode> parents;
        private string title;
        private Subject<MouseData> mouseDownObservable;
        private double canvasLeft;
        private double canvasTop;
        private MouseData mouse_data;
        private int original;
        private Window window;
        private AbstractNode parent;
        private MyButton remove_btn;
        private MyButton prop_btn;
        private bool isVisited;
        public NonBinaryNode()
        {
			this.parents = new List<AbstractNode>();
            this.children = new List<AbstractNode>();
            this.title = "";
            mouseDownObservable = new Subject<MouseData>();
            mouse_data = new MouseData();
            this.Original = 1;
            this.isVisited = false;
        }

        public bool IsVisited
        {
            get { return isVisited; }
            set { isVisited = value; }
        }
        public List<AbstractNode>  Children
        {
            get { return children; }
            set { children = value; }
        }
        public List<AbstractNode> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public MyButton Prop_btn
        {
            get { return prop_btn; }
            set { prop_btn = value; OnPropertyChanged("Prop_btn"); }
        }
        public MyButton Remove_btn
        {
            get { return remove_btn; }
            set { remove_btn = value; OnPropertyChanged("Remove_btn"); }
        }

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }


        public Subject<MouseData> MouseDownObservable
        {
            get { return mouseDownObservable; }
            set { mouseDownObservable = value; OnPropertyChanged("MouseDownObservable"); }
        }

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


        public MouseData Mouse_Data
        {
            get { return mouse_data; }
            set { mouse_data = value; OnPropertyChanged("Mouse_Data"); }
        }

        public int Original
        {
            get { return original; }
            set { original = value; OnPropertyChanged("Original"); }
        }

        public Window Window_
        {
            get { return window; }
            set { window = value; }
        }


        public AbstractNode Parent
        {
            get { return parent; }
            set { parent = value; OnPropertyChanged("Parent"); }
        }


        public void addChild(AbstractNode c)
        {
            this.children.Add(c);
        }

        public void addParent(AbstractNode c)
        {
            this.parents.Add(c);
        }

        public bool isLeaf()
        {
            return this.children.Count ==0;
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
