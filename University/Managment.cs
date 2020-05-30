using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using University.Models;

namespace University
{
  public static  class Managment
    {

        public static Facultet CreateFacultet (string name)
        {
            return new Facultet() { Name = name };
        } 

        public static void DeleteFacultet(Facultet[] facultets ,string fac_name)
        {
            var facultet = facultets.Where(x => x.Name == fac_name).SingleOrDefault();
            if (facultet!=null)
            {
                facultet = null;
            }
        }

        public static void UpdateFacultet(Facultet facultet, Facultet[] facultets)
        {
            var f = facultets.Where(x => x.Name ==facultet.Name).SingleOrDefault();
            if (f!=null)
            {
                f = facultet;
            }
        }

        public static Department CreateDepartment(string name)
        {
            return new Department() { Name = name };
        }

        public static void DeleteDepartment(Department[] departments, string dep_name)
        {
            var department = departments.Where(x => x.Name == dep_name).SingleOrDefault();
            if (department != null)
            {
                department = null;
            }
        }

        public static void UpdateDepartment(Department department, Department[] departments)
        {
            var d = departments.Where(x => x.Name == department.Name).SingleOrDefault();
            if (d != null)
            {
                d = department;
            }
        }

        public static void AddPersonToDepartment(Person person,Department department)
        {
            if (person is Student)
            {
                department.Students.Add((Student)person);

            }
            if (person is Teacher)
            {
                department.Teachers.Add((Teacher)person);
            }
        }

    }
}
