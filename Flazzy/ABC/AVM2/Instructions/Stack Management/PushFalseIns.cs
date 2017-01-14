﻿using System;

namespace Flazzy.ABC.AVM2.Instructions
{
    public class PushFalseIns : OperandPusher
    {
        public override object Value
        {
            get { return false; }
            set { throw new NotSupportedException(); }
        }

        public PushFalseIns()
            : base(OPCode.PushFalse)
        { }
    }
}