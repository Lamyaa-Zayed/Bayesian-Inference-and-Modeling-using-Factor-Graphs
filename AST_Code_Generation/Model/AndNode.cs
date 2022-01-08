using AST_Code_Generation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class AndNode : AbstractNode
    {

        public AndNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public AndNode(string title)
        {
            this.Title = title;
            //this.Window_ = new ArrayWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new AndWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        
    }
}