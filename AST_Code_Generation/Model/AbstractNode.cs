using System;
using System.Collections.Generic;
using System.Text;

namespace AST_Code_Generation
{
    public abstract class AbstractNode: NonBinaryNode
    {
        public abstract string accept(AbstractVisitor visitor);
        public abstract void Show_Win();
    }
}
