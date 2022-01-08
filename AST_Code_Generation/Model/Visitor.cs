using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public class Visitor : AbstractVisitor

    {
        string a = "";
        public override string generate(AbstractNode root)
        {
            if (root.IsVisited == false)
            {
                foreach (AbstractNode r in root.Parents)
                {
                    if (r.Parent == null)
                    {
                        break;
                    }
                    else
                    {
                        a = generate(r);// + "\n";
                    }

                }
                if (root.GetType().ToString() == "AST_Code_Generation.GaussianNode")
                {
                    a += "Variable<double> " + root.Title + " = Variable.GaussianFromMeanAndPrecision(" + root.Parents[0].Title + ", " + root.Parents[1].Title + ");";
                }
                else if (root.GetType().ToString() == "AST_Code_Generation.ObservedGaussianNode")
                {
                    a += "Variable<double> " + root.Title + " = Variable.GaussianFromMeanAndPrecision(" + root.Parents[0].Title + ", " + root.Parents[1].Title + ");";
                }
                else if (root.GetType().ToString() == "AST_Code_Generation.GammaNode")
                {
                    a += "Variable<double> " + root.Title + " = Variable.GammaFromShapeAndScale(" + root.Parents[0].Title + ", " + root.Parents[1].Title + ");\n";
                }
                else if (root.GetType().ToString() == "AST_Code_Generation.BernoulliNode")
                {
                    a += "Variable<bool> " + root.Title + " = Variable.Bernoulli(" + root.Parents[0].Title + ");\n";
                }
                else if (root.GetType().ToString() == "AST_Code_Generation.ObservedBernoulliNode")
                {
                    a += "Variable<bool> " + root.Title + " = Variable.New<bool>();\n";
                    a += "using (Variable.If(" + root.Parents[0].Title + "))\n{\n" + root.Title + ".SetTo(Variable.Bernoulli(" + ((ObservedBernoulliNode)root).ValueWhenTrue + "));\n}\n" +
                         "using (Variable.IfNot(" + root.Parents[0].Title + "))\n{\n" + root.Title + ".SetTo(Variable.Bernoulli(" + ((ObservedBernoulliNode)root).ValueWhenFalse + "));\n}\n";
                }
                else if (root.GetType().ToString() == "AST_Code_Generation.AndNode")
                {
                    a += "Variable<bool> " + root.Title + " = Variable<bool>.Factor(Factor.And, " + root.Parents[0].Title + ", " + root.Parents[1].Title+");\n";
                }
                else if (root.GetType().ToString() == "AST_Code_Generation.GaussianArrayNode")
                {
                    //string[] teamNames = new string[] { "Angels", "Bruins", "Comets", "Demons", "Eagles", "Flyers" };
                    a += ((ArrayNode)root.Parents[2]).Type+"[] "+root.Title+" = new "+ ((ArrayNode)root.Parents[2]).Type + "[] { "+ ((ArrayNode)root.Parents[2]).ArrayString+"};";
                    a += "Range "+ ((ArrayNode)root.Parents[2]).Title + "Range"+" = new Range("+ ((ArrayNode)root.Parents[2]).Title+".length);";
                    a += "VariableArray<" + ((ArrayNode)root.Parents[2]).Type + "> " + root.Title + " = Variable.Array<" + ((ArrayNode)root.Parents[2]).Type + "> (" + ((ArrayNode)root.Parents[2]).Title + "Range" + ");";
                    a += "using (Variable.ForEach(" + ((ArrayNode)root.Parents[2]).Title + "Range" + ")){ "+ root.Title +"["+ ((ArrayNode)root.Parents[2]).Title + "Range" +"] = Variable.GaussianFromMeanAndVariance("+root.Parents[0].Title+", "+ root.Parents[1].Title+") +  };";
                }
                root.IsVisited = true;
            }
            return a;

            //string a = "";
            //if (root.isLeaf())
            //{
            //    a = root.accept(this);
            //    return a;
            //}
            //else
            //{
            //    if (root.GetType().ToString() == "AST_Code_Generation.IfNode")
            //    {
            //        a += root.accept(this);
            //        a += "(" + generate(root.Children[0]) + ")";

            //        a += "\n{\n";

            //        for(int i=1; i<root.Children.Count; i++)
            //        {
            //            a += generate(root.Children[i]);
            //        }

            //        a += "\n}\n";
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.WhileNode")
            //    {
            //        a += root.accept(this);
            //        a += "(" + ((WhileNode)root).r.Start + ":" + ((WhileNode)root).r.End + ")";

            //        a += "\n{\n";

            //        for (int i = 0; i < root.Children.Count; i++)
            //        {
            //            a += generate(root.Children[i]);
            //        }

            //        a += "\n}\n";
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.ForNode")
            //    {
            //        a += root.accept(this);
            //        a += "(" + ((ForNode)root).r.Start + ":" + ((ForNode)root).r.End + ")";

            //        a += "\n{\n";

            //        for (int i = 0; i < root.Children.Count; i++)
            //        {
            //            a += generate(root.Children[i]);
            //        }

            //        a += "\n}\n";
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.OpNode")
            //    {
            //        a += generate(root.Children[0]);
            //        a += root.accept(this);
            //        a += generate(root.Children[1]);
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.RangeNode")
            //    {
            //        if (root.Children[0].GetType().ToString() == "AST_Code_Generation.ConstantNode")
            //        {
            //            ((RangeNode)root).RangeValue = root.Children[0].Title;
            //        }
            //        else if (root.Children[0].GetType().ToString() == "AST_Code_Generation.ArrayNode")
            //        {
            //            //((RangeNode)root).RangeValue = ((ArrayNode)root.Children[0]).GetArray().Length.ToString();
            //            ((RangeNode)root).RangeValue = root.Children[0].Title + ".Length";
            //        }
            //        a += "Range " + ((RangeNode)root).Title + " = " + "new Range(" + ((RangeNode)root).RangeValue + ");";
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.ForEachNode")
            //    {
            //        a += "using (Variable.ForEach(" + ((ForEachNode)root).Range + "))";
            //        a += "\n{\n";
            //        for (int i = 0; i < root.Children.Count; i++)
            //        {
            //            a += generate(root.Children[i]);
            //        }
            //        a += "\n}\n";
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.VariableArrayNode")
            //    {
            //        a += root.Title + '[' + root.Children[0].Title + ']';
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.ObservedValueNode")
            //    {
            //        a += generate(root.Children[0]) + ".ObservedValue = " + generate(root.Children[1]) + ';';
            //    }
            //    else if (root.GetType().ToString() == "AST_Code_Generation.ConstrainNode")
            //    {
            //        a += "Variable.ConstrainTrue(" + root.Children[0].Title + root.Title + root.Children[1].Title +");";
            //    }
            //    else
            //    {
            //        for (int i = 0; i < root.Children.Count; i++)
            //        {
            //            a += generate(root.Children[i]);
            //            a += root.accept(this);
            //        }

            //    }

            //    return a;
            //}
        }
        public override string visit(VarNode n)
        {
            //return n.Title;
            return "Variable<" + n.Type + "> " + n.Title;
        }

        public override string visit(OpNode n)
        {
            return n.Title;
        }

        public override string visit(SpaceNode n)
        {
            return "\n";
        }

        public override string visit(IfNode n)
        {
            return n.Title;
        }

        public override string visit(ForNode n)
        {
            return n.Title;
        }
        
        public override string visit(ObservedGaussianNode n)
        {
            return n.Title;
        }

        public override string visit(WhileNode n)
        {
            return n.Title;
        }

        public override string visit(ConstantNode n)
        {
            return n.Title;
        }

        public override string visit(ArrayNode n)
        {
            if (n.Type.Equals("") && n.ArrayString.Equals(""))
            {
                return n.Title;
            }
            else
            {
                return n.Type + "[] " + n.Title + " = " + "new " + n.Type + "[] {" + n.ArrayString + "};";
            }
        }

        public override string visit(RangeNode n)
        {
            if (n.RangeValue.Equals(""))
            {
                return n.Title;
            }
            else
            {
                return "Range " + n.Title + " = " + "new Range(" + n.RangeValue + ");";
            }
        }

        public override string visit(ForEachNode n)
        {
            return "using (Variable.ForEach( ))\n{\n\n}\n";
        }

        public override string visit(VariableArrayNode n)
        {
            if (n.Type.Equals("") && n.Range.Equals(""))
            {
                return n.Title;
            }
            else
            {
                return "VariableArray<" + n.Type + "> " + n.Title + " = Variable.Array<" + n.Type + ">(" + n.Range + ");";
            }
        }

        public override string visit(GaussianNode n)
        {
            return "Variable.GaussianFromMeanAndVariance(" + n.Mean + "," + n.Variance + ");";
        }

        public override string visit(GammaNode n)
        {
            return "Variable.GammaFromShapeAndScale(" + n.Alpha + "," + n.Beta + ");";
        }

        public override string visit(ObservedValueNode n)
        {
            return n.Title;
        }

        public override string visit(ConstrainNode n)
        {
            return n.Title;
        }

        public override string visit(EngineNode n)
        {
            String str = "var " + n.Title + " = new InferenceEngine();" + "\n";
            str += n.Title + ".Algorithm = new " + n.Algorithm + "();" + "\n";
            str += n.Title + ".NumberOfIterations = " + n.NumberOfIterations + ";" + "\n";
            return str;
        }

        public override string visit(InferNode n)
        {
            return n.EngineName + ".Infer<" + n.Type + "[]>(" + n.Observale + ");";
        }

        public override string visit(BernoulliNode n)
        {
            throw new NotImplementedException();
        }

        public override string visit(ObservedBernoulliNode n)
        {
            throw new NotImplementedException();
        }

        public override string visit(AndNode n)
        {
            throw new NotImplementedException();
        }

        public override string visit(GaussianArrayNode n)
        {
            throw new NotImplementedException();
        }
    }
}
