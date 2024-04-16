using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // interface
    // in java have 2 different words Extends and implements
    //Extends Emp --> manager add 
    //implements structure --> implement (class)
    // collections Add, remove, index, sort, reverse
    // when we want to share common behavior(mathod) with multiple classes which are not in hiriarchy
    // interface in c# provides a contract for the classes
    //paytax(); different for each person so we will put it in interface

    interface ITaxable
    {
        void paytax();
    }
    public class InterfaceDemo:ITaxable
    {
        public void paytax()
        {
            //logic is different for different class
        }
    }
    // **SOLID principles**
    // Rules for interfaces
    // 1. interface is a reference type in c#
    // 2. All the members are by default public. no need to write explicit access specifier
    // 3. Interface can have declaration of methods, properties(auto implemented) and events
    // 4. Any class that implements the interface neewds to provide implementation for each method
    // 5. class can implements multiple interfaces
    //  Amazon prime video
    //  Movie, sports, web series, channels
    //eg. 

    /*public class Customer1 : Movies, sports
    {
        Movies --> bollywood, hollywood
        sports -->IPL, football
    }*/
    /*public class Customer2 : Movies
    {
        Movies --> bollywood, hollywood
    }*/
    // implicite interface implementation
    //explicite interface implementation
    // In c# interface name should start with I eg. ITaxable, IPrintable, IList
    // 
}
