using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ObservedValueNode : AbstractNode
    {
        public ObservedValueNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public ObservedValueNode(string title)
        {
            this.Title = title;
        }
        public override void Show_Win()
        {

        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
