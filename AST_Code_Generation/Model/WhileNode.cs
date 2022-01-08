﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class WhileNode : AbstractNode
    {
        private Range range;


        public Range r
        {
            get { return range; }
            set { range = value; }
        }
        public WhileNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public WhileNode(string title)
        {
            this.Title = title;
            //this.Window_ = new WhileWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new WhileWindow(this);
            this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
