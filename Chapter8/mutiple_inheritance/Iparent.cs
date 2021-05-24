using System;
using System.Collections.Generic;
using System.Text;

namespace mutiple_inheritance
{
    // interface as one parent
    interface Iparent
    {
        public void getdata();
    }
    //Branch as second parent 
    class Branch
    {
        string place;
        public void getPlace()
        {
            place = "Korea";
            Console.WriteLine(place);
        }
    }
}
