using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class OpNode : AbstractNode
    {
        public OpNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public OpNode(string title)
        {
            this.Title = title;
           // this.Window_ = new OpWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new OpWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
