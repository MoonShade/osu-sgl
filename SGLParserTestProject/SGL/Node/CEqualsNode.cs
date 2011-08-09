﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class CEqualsNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public CEqualsNode(SGLNode lhs, SGLNode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = lhs.Evaluate();
            SGLValue b = rhs.Evaluate();

            return new SGLValue(a.Equals(b));
        }


        public String ToString()
        {
            return lhs.ToString() + " == " + rhs.ToString();
        }


    }
}
