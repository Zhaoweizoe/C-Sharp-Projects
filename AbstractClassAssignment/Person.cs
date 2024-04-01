using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Create an abstract class "Person" with two string properties:firstname and lastname
    public abstract class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        //Give it the method SayName().
        public abstract void SayName();

    }
}
