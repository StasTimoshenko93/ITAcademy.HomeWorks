using System;
using System.Collections.Generic;
using System.Reflection;


namespace HW09.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcyclePublic motoPublic = new MotorcyclePublic();
            motoPublic.maxspeedProtectedInternal = 10;
            motoPublic.namePublic = "Honda";
            motoPublic.GetNameInternal();
            //velocityPrivate = 12; closed
            //motoPublic.SetNamePrivateProtected(); closed
            //motoPublic.MoveProtected(); closed

            MotorcycleInternal motoInternal = new MotorcycleInternal();
            motoInternal.maxspeedProtectedInternal = 12;
            motoInternal.namePublic = "BMW";
            motoInternal.GetNameInternal();
            

            MotoInternalChild child1 = new MotoInternalChild();
            child1.maxspeedProtectedInternal = 15;
            child1.namePublic = "Honda";
            child1.GetNameInternal();

            MotoPublicChild child2 = new MotoPublicChild();
            child2.GetNameInternal();
            child2.maxspeedProtectedInternal = 124;
            child2.namePublic = "BMW"; 
        }
    }
}
