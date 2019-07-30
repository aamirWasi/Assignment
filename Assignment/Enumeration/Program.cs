using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public enum RegistrationStatus
    {
        Active,
        Inactive,
        Blocked
    }
    public enum UserType
    {
        Member,
        Support,
        Admin,
        SuperAdmin
    }
    public class User
    {
        public string Name { get; set; }
        public RegistrationStatus Status { get; set; }
        public UserType Type { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            if (user.Status == RegistrationStatus.Active &&
                user.Type == UserType.Admin)
            {
                Console.WriteLine("Login in successfully...");
            }
        }
    }
}
