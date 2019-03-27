using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Name
    {
        public Name(string _first_name,string _second_name)
        {
            first_name = _first_name;
            second_name = _second_name;
        }
        public Name()
        {
        }
        public string first_name;
        public string second_name;
    }
    class Address : Name
    {
        public Address(string _address, int _postcode, string _first_name, string _second_name) : base (_first_name,_second_name)
        {
            address = _address;
            postcode = _postcode;
        }
        public Address()
        {
        }
        public string address;
        public int postcode;
    }
    class Contact_Info : Name
    {
        public Contact_Info(string _first_name, string _second_name, int _phone_number, string _email): base(_first_name, _second_name)
        {

        }
        public Contact_Info()
        {
        }
        public int phone_number;
        public string email;
    }
    class Student_Card: Address
    {
        public Student_Card(string _address, int _postcode, string _first_name, string _second_name, int _index_number, string _validity_time, bool _hall_of_residence_resident) : base (_address,_postcode,_first_name,_second_name)
        {
            validity_time = _validity_time;
            index_number = _index_number;
            hall_of_residence_resident = _hall_of_residence_resident;
        }
        public Student_Card()
        {
        }
        public int index_number;
        public bool hall_of_residence_resident;
        public string validity_time;
    }
    class Medical_Record : Address
    {
        public Medical_Record(string _address, int _postcode, string _first_name, string _second_name, int _pesel, string _authorised_person): base (_address,_postcode,_first_name,_second_name)
        {
            pesel = _pesel;
            authorised_person = _authorised_person;
        }
        public Medical_Record()
        {       
        }
        public int pesel;
        public string authorised_person;
    }
    class Bank_Account : Address
    {
        public Bank_Account(string _address, int _postcode, string _first_name, string _second_name, int _account_number, double _balance): base (_address,_postcode,_first_name,_second_name)
        {
            account_number = _account_number;
            balance = _balance;
        }
        public Bank_Account()
        {
        }
        public int account_number;
        public double balance;
    }
    class Pay_Card :Bank_Account
    {
        public Pay_Card(string _address, int _postcode, string _first_name, string _second_name, int _account_number, double _balance, int _card_number) : base(_address, _postcode, _first_name, _second_name,_account_number,_balance)
        {
            card_number = _card_number;
        }
        public Pay_Card()
        {
        }
        public int card_number;
    }

}
