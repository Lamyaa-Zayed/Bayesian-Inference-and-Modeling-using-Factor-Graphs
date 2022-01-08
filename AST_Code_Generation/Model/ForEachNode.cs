using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ForEachNode : AbstractNode
    {

        public ForEachNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public ForEachNode(string title)
        {
            this.Title = title;
            //this.Window_ = new ForEachWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new ForEachWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String range;

        public string Range
        {
            get { return range; }
            set { range = value; OnPropertyChanged("Range"); }
        }
    }
}
