using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //public string FirstName;
        public int Id { get; set; }
        //public string FirstName { get; set; }

        private string _firstName;

        public string FirstName
        {
            get
            {
                if (Cinsiyet == 1)
                {
                    return "Mrs. " + _firstName;
                }
                else
                {
                    return "Mr. " + _firstName;
                }

            }
            set { _firstName = value.Trim(); }
        }

        public string LastName { get; set; }
        public string City { get; set; }
        public int YearOfBirth { get; set; }
        public string TcNo { get; set; }

        public int Cinsiyet { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private string _creditCardNumber;

        public string CreditCardNumber
        {
            set { _creditCardNumber = value; }
        }


    }
}
