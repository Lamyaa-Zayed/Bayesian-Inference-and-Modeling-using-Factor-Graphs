using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public abstract class AbstractVisitor
    {
        public abstract string visit(VarNode n);
        public abstract string visit(OpNode n);
        public abstract string visit(SpaceNode n);
        public abstract string generate(AbstractNode root);
        public abstract string visit(IfNode n);
        public abstract string visit(ConstantNode n);
        public abstract string visit(ForNode n);
        public abstract string visit(WhileNode n);
        public abstract string visit(ObservedGaussianNode n);
        public abstract string visit(ArrayNode n);
        public abstract string visit(RangeNode n);
        public abstract string visit(ForEachNode n);
        public abstract string visit(VariableArrayNode n);
        public abstract string visit(GaussianNode n);
        public abstract string visit(ObservedValueNode n);
        public abstract string visit(ConstrainNode n);
        public abstract string visit(EngineNode n);
        public abstract string visit(InferNode n);
        public abstract string visit(GammaNode n);
        public abstract string visit(BernoulliNode n);
        public abstract string visit(ObservedBernoulliNode n);
        public abstract string visit(AndNode n);
        public abstract string visit(GaussianArrayNode n);
    }
}
