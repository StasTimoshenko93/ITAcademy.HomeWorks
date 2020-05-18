using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.AssemblyOne
{
    class MotoInternalChild : MotorcycleInternal
    {
        void MoveProtecteds()
        {
            namePublic = "dd";
            //velocityPrivate = 10; closed
            maxspeedProtectedInternal = 12;
            MoveProtected();
            GetNameInternal();
            SetNamePrivateProtected();
        }
    }
}
