using AST_Code_Generation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class BernoulliNode : AbstractNode
    {

        public BernoulliNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public BernoulliNode(string title)
        {
            this.Title = title;
            //this.Window_ = new DistributionWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new BernoulliWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

       
    }
}
