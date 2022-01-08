using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class VarNode : AbstractNode
    {
        public VarNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public VarNode(string title)
        {
            this.Title = title;
            //this.Window_ = new VarWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new VarWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String type = "";

        public String Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }
    }
}
