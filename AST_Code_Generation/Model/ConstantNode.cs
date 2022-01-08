using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ConstantNode : AbstractNode
    {
        public ConstantNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public ConstantNode(string title)
        {
            this.Title = title;
        }
        public override void Show_Win()
        {
            this.Window_ = new ConstantWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
