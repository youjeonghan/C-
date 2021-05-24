using System;
using System.Collections.Generic;
using System.Text;

namespace hybrid_inheritance
{
    //intermediate parent inteface for Child.cs 
    interface Interface3 : Interface1, Interface2
    {
        //abstract method to calculate sum 
        public void Sum();
    }
}
