using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavourCompositionOverInheritance
{
    //Has-a relationship
    class Program
    {
        static void Main(string[] args)
        {
            var university = new University();
            university.AddDepartment("Dev Skill", "jalal uddin", Dept.computer, 12);

            university.AddDepartment("Dev Skill", "jalal uddin", Dept.art, 200);

            foreach (var item in university.Departments)
            {
                if (item is ArtDept art)
                {
                    Console.WriteLine($"Name of Institution : {art.DeptName}" +
                        $" Director's Name : {art.DepartmentHeadName}" +
                        $" Total StudentsNumber : {art.StudentsNumber}");
                }
                else if (item is ComputerDept compDept)
                {
                    Console.WriteLine($"Name of Institution : {compDept.DeptName}" +
                        $" Director's Name : {compDept.DepartmentHeadName}" +
                        $" Total Labs : {compDept.Labs}");
                }
            }
        }
    }
}
