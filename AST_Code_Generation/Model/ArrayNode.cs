using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class ArrayNode : AbstractNode
    {

        public ArrayNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public ArrayNode(string title)
        {
            this.Title = title;
            //this.Window_ = new ArrayWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new ArrayWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String type="";
        private String arrayString="";

        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }

        public string ArrayString
        {
            get { return arrayString; }
            set { arrayString = value; OnPropertyChanged("ArrayString"); }
        }

        public Array GetArray() {

            return arrayString.Split(',');
        }

    }
}
