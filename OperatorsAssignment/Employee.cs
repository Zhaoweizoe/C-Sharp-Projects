using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    // Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //behavior: Constructor to initialize the properties
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        // Overloading the "==" operator to check if two Employee objects refer to the same instance
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both references are null, return true
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // If one reference is null while the other isn't, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare references
            return ReferenceEquals(emp1, emp2);
        }

        // Overloading the "!=" operator (required for pairs of overloaded operators)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

    }
}
