using System;
using System.Collections.Generic;
using System.Text;

namespace Iparent
{
    interface Iparent
    {
        //by default method under interface are public 
        //by defacult methods are abstract 
        void sum(int a, int b);
        void sub(int a, int b);
    }
    interface Iparent1
    {
        void mul(int a, int b);
    }
}
