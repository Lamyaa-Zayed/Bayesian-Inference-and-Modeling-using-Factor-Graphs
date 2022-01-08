using AST_Code_Generation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ObservedGaussianNode : AbstractNode
    {
        private String observedValue;


        public String ObservedValue
        {
            get { return observedValue; }
            set { observedValue = value; }
        }
        public ObservedGaussianNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public ObservedGaussianNode(string title)
        {
            this.Title = title;
            //this.Window_ = new WhileWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new ObservedGaussianWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
