﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class EngineNode : AbstractNode
    {
        public EngineNode(string title, double canvasleft, double canvastop)
        {
            this.Title = title;
            this.CanvasLeft = canvasleft;
            this.CanvasTop = canvastop;
        }

        public EngineNode(string title)
        {
            this.Title = title;
            //this.Window_ = new GeneralWindow(this);
        }
        public override void Show_Win()
        {
            this.Window_ = new EngineWindow(this);
            this.Window_.Show();
        }

        public override string accept(AbstractVisitor visitor)
        {
            return visitor.visit(this);
        }

        private String algorithm;
        private String numberOfIterations;

        public string Algorithm
        {
            get { return algorithm; }
            set { algorithm = value; OnPropertyChanged("Algorithm"); }
        }

        public string NumberOfIterations
        {
            get { return numberOfIterations; }
            set { numberOfIterations = value; OnPropertyChanged("NumberOfIterations"); }
        }

    }
}
