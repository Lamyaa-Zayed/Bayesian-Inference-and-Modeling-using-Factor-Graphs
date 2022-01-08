using AST_Code_Generation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ObservedBernoulliNode : AbstractNode
    {
        private String valueWhenTrue;
        private String valueWhenFalse;
        private String trueORfalse;


        public String ValueWhenTrue
        {
            get { return valueWhenTrue; }
            set { valueWhenTrue = value; }
        }

        public String ValueWhenFalse
        {
            get { return valueWhenFalse; }
            set { valueWhenFalse = value; }
        }

        public String TrueORfalse
        {
            get { return trueORfalse; }
            set { trueORfalse = value; }
        }
        public ObservedBernoulliNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public ObservedBernoulliNode(string title)
        {
            this.Title = title;
            //this.Window_ = new WhileWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new ObservedBernoulliWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
