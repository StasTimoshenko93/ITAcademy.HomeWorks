using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.AssemblyOne
{
    public class MotoPublicChild:MotorcyclePublic
    {
        void MoveProtecteds()
        {
            namePublic = " ";
            //velocityPrivate = 12; closed
            maxspeedProtectedInternal = 122;
            MoveProtected();
            GetNameInternal();
            SetNamePrivateProtected();
        }
    }
}
