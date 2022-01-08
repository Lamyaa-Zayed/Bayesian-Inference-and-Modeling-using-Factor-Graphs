//using AST_Code_Generation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class InferNode : AbstractNode
    {
        public InferNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public InferNode(string title)
        {
            this.Title = title;
            //this.Window_ = new InferWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new InferWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String engineName;
        private String type;
        private String observale;

        public string EngineName
        {
            get { return engineName; }
            set { engineName = value; OnPropertyChanged("EngineName"); }
        }

        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }

        public string Observale
        {
            get { return observale; }
            set { observale = value; OnPropertyChanged("Observale"); }
        }
    }
}
