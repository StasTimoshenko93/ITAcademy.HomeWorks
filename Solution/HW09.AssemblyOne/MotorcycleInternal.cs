using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.AssemblyOne
{
    internal class MotorcycleInternal
    {
        public string namePublic;
        private int velocityPrivate;
        protected internal int maxspeedProtectedInternal;
        protected void MoveProtected() { }
        internal void GetNameInternal() { }
        private protected void SetNamePrivateProtected() { }

        void MoveProtecteds() 
        {
            namePublic = " ";
            velocityPrivate = 12;
            maxspeedProtectedInternal = 122;
            MoveProtected();
            GetNameInternal();
            SetNamePrivateProtected();    
        }
    }
}
