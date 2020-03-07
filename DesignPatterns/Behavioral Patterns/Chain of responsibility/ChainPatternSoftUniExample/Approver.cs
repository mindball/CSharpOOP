﻿namespace ChainPatternSoftUniExample
{
    internal abstract class Approver
    {
        protected Approver Successor { get; set; }

        public void SetSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
