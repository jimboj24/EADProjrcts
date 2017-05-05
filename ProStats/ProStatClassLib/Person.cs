using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProStatClassLib
{
    public class Person
    {
        protected string personId;
        protected string firstName;
        protected string lastName;
        protected string middleName;
        protected DateTime birthDate;
        protected string phone1;
        protected string phone2;
        
        //private string programme;


        //Default constructor
        public Person() { }
        public Person(string personId, string firstName, string lastName, string middleName,
            DateTime birthDate, string phone1, string phone2)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.birthDate = birthDate;
            this.phone1 = phone1;
            this.phone2 = phone2;
           
            


        }
        //Getters and setters
        public string PersonId
        {
            get
            {
                return personId;
            }
            set
            {
                personId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }

        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }

        }

        public string Phone1
        {
            get
            {
                return phone1;
            }
            set
            {
                phone1 = value;
            }
        }
        public string Phone2
        {
            get
            {
                return phone2;
            }
            set
            {
                phone2 = value;
            }

        }

    }
}

