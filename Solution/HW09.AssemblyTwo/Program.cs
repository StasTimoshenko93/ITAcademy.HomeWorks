using HW09.AssemblyOne;
using System;


namespace HW09.AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcyclePublic motoPublic = new MotorcyclePublic();
            motoPublic.namePublic = "Honda";
            //motoPublic.maxspeedProtectedInternal = 10; closed
            //motoPublic.GetNameInternal(); closed
            //motoPublic.velocityPrivate = 12; closed
            //motoPublic.SetNamePrivateProtected(); closed
            //motoPublic.MoveProtected(); closed

            //MotorcycleInternal motoInternal = new MotorcycleInternal(); closed

            //MotoInternalChild child1 = new MotoInternalChild(); closed

            MotoPublicChild child2 = new MotoPublicChild();
            child2.namePublic = "wewe";
        }
    }
}
