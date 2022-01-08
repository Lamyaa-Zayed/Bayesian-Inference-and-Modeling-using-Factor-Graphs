using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class GammaNode : AbstractNode
    {
        public GammaNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public GammaNode(string title)
        {
            this.Title = title;
            //this.Window_ = new GammanWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new GammaWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String alpha;
        private String beta;

        public string Alpha
        {
            get { return alpha; }
            set { alpha = value; OnPropertyChanged("Alpha"); }
        }

        public string Beta
        {
            get { return beta; }
            set { beta = value; OnPropertyChanged("Beta"); }
        }

    }
}
