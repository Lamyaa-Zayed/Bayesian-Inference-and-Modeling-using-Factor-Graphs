﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class SpaceNode : AbstractNode
    {
        public SpaceNode(string title)
        {
            this.Title = title;
        }

        public SpaceNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }
        public override void Show_Win()
        {
           // this.Window_ = new VarWindow(this);
           // this.Window_.Show();
        }
        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
