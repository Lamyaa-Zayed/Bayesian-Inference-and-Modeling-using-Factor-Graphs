
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class GaussianNode : AbstractNode
    {
        public GaussianNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public GaussianNode(string title)
        {
            this.Title = title;
            //this.Window_ = new GaussianWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new GaussianWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String mean;
        private String variance;

        public string Mean
        {
            get { return mean; }
            set { mean = value; OnPropertyChanged("Mean"); }
        }

        public string Variance
        {
            get { return variance; }
            set { variance = value; OnPropertyChanged("Variance"); }
        }

    }
}