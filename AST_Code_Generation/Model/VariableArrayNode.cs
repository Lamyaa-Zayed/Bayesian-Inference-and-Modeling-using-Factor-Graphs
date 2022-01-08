using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class VariableArrayNode : AbstractNode
    {
        public VariableArrayNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public VariableArrayNode(string title)
        {
            this.Title = title;
            //this.Window_ = new VariableArrayWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new VariableArrayWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String type = "";
        private String range = "";

        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }

        public string Range
        {
            get { return range; }
            set { range = value; OnPropertyChanged("Range"); }
        }


    }
}