using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreclasspractice
{
    class Contact
    {

        private string name; //fields
        private string address; //fields
        private string phoneNumber; //fields

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;

            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        // constructors

        public Contact()
        {
            name = "Camille Pouncy";
            address = "blah blah";
            phoneNumber = "666 - 666 - 6666";
        }

        public Contact(string contactName, string contactAdress)
        {
            name = contactName;
            address = contactAdress;
        }
        public override string ToString()
        {
            return $"{name} lives at {address} and can be reached at {phoneNumber}"; //It is call base because it is referencing the parent class. 
        }
        public static Contact AddContact()
        {
            Console.WriteLine("Hwat is the name of your contact" );
            string contactName = Console.ReadLine();
            Console.WriteLine("Hwat is their address?");
            string contactAddress = Console.ReadLine();
            return new Contact(contactName, contactAddress);
        }

    }
}
