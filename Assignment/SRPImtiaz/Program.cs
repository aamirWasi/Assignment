using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPImtiaz
{
    public class Employee
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string Department { get; set; }
        //public bool  Working { get; set; }
        private readonly int _id;
        private readonly string _name;
        private readonly string _departnemt;
        private readonly bool _working;
        public Employee(int id,string name,string department,bool working)
        {
            _id = id;
            _name = name;
            _departnemt = department;
            _working = working;
        }
        public override string ToString()
        {
            return $"ID : {_id} name : {_name} Department : {_departnemt} Working : {_working}";
        }
        public string Department { get; }
    }
    public class EmployeeDAO
    {
        public void SaveEmployee(Employee employee)
        {

        }
        public void DeleteEmployee(Employee employee)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
