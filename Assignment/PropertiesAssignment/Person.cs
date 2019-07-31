using System;

namespace PropertiesAssignment
{
    public class Person
    {
        Cities _city;
        bool _status;

        public DateTime BirthDate { get; private set; }
        public Person(DateTime birthDate,Cities city,bool status)
        {
            BirthDate = birthDate;
            _city = city;
            _status = status;
        }
        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status == true)
                    _status = value;
            }
        }
        public Cities City
        {
            get
            {
                return _city;
            }
            set
            {
                if (_status == true)
                    _city = value;
            }
        }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                return timeSpan.Days/365;
            }
        }
    }
}
