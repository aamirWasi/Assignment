using System;
using System.Collections.Generic;

namespace FavourCompositionOverInheritance
{
    public class University
    {
        public List<Department> Departments { get; set; }
        public University()
        {
            Departments = new List<Department>();
        }
        public void AddDepartment(string name,string headName,Dept dept,int number)
        {
            if (dept == Dept.art)
            {
                var art = new ArtDept
                {
                    DeptName = name,
                    DepartmentHeadName = headName,
                    StudentsNumber = number
                };
                Departments.Add(art);
            }
            else if (dept == Dept.computer)
            {
                var computer = new ComputerDept
                {
                    DeptName = name,
                    DepartmentHeadName = headName,
                    Labs = number
                };
                Departments.Add(computer);
            }
            else if (dept == Dept.Biz)
            {
                var biz = new BizDepartment
                {
                    DeptName = name,
                    DepartmentHeadName = headName,
                    Sessions = number
                };
                Departments.Add(biz);
            }
        }
    }
}
