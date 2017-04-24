using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProStatClassLib
{
    class Person
    {
        private string personId;
        private string firstName;
        private string lastName;
        private string middleName;
        private string address;
        private string city;
        private string parish;

        //Default constructor
        public Person() { }
        public Person(string personId, string firstName, string lastName, string middleName,
            string address, string city, string parish)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.address = address;
            this.city = city;
            this.parish = parish;
        }
        //Getters and setters
        public string PersonId
        {
            get
            {
                return PersonId;
            }
            set
            {
                PersonId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        
        }
 
    
    }


}
