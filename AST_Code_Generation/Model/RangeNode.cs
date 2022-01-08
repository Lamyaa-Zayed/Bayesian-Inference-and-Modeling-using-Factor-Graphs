using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class RangeNode : AbstractNode
    {

        public RangeNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public RangeNode(string title)
        {
            this.Title = title;
            //this.Window_ = new RangeWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new RangeWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String rangeValue = "";

        public String RangeValue
        {
            get { return rangeValue; }
            set { rangeValue = value; OnPropertyChanged("RangeValue"); }
        }

    }
}
