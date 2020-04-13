using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP
{
    public abstract class Bird
    {
        public abstract void Walk();
    }

    public abstract class FlyingBirds : Bird
    {
        public abstract void Fly();
    }

    public class Duck : FlyingBirds 
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
        public override void Walk()
        {
            throw new NotImplementedException();
        }
    } // Walk , Fly
    public class Penguin : Bird 
    {
        public override void Walk()
        {
            throw new NotImplementedException();
        }
    } // Walk
}
