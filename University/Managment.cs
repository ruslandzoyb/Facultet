using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public static void RemovePersonFromDepartment(Person person ,Department department)
        {
            var st = department.Students.Where(x => x.Name == person.Name && x.Surname == person.Surname && x.Group == ((Student)person).Group).FirstOrDefault();
           var  t= department.Teachers.Where(x => x.Name == person.Name && x.Surname == person.Surname && x.Subject == ((Teacher)person).Subject).FirstOrDefault();
            if (st!=null)
            {
                department.Students.Remove(st);
            }
            if (t != null)
            {
                department.Teachers.Remove(t);
            }

        }

        public static void UpdatePersonFromDepartment(Person person,Department department)
        {
            var st = department.Students.Where(x => x.Name == person.Name && x.Surname == person.Surname && x.Group == ((Student)person).Group).FirstOrDefault();
            var t = department.Teachers.Where(x => x.Name == person.Name && x.Surname == person.Surname && x.Subject == ((Teacher)person).Subject).FirstOrDefault();

            if (st!=null)
            {
                st = (Student)person
;            }

            if (t != null)
            {
                t = (Teacher)person
;
            }
        }


        public static Person FindByFIO(string name ,string surname,Department department)
        {
            var s = department.Students.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
            if (s!=null)
            {
                return s;
            }
            else
            {
                var t = department.Teachers.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
                if (t!=null)
                {
                    return t;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

       public static Student FindByGroup(string group,Department department) {
            var st = department.Students.Where(x => x.Group == group).FirstOrDefault();
            if (st!=null)
            {
                return st;
            }
            throw new Exception();
        }

        public static Student FindByCourse(int course, Department department)
        {
            var st = department.Students.Where(x => x.Course == course).FirstOrDefault();
            if (st != null)
            {
                return st;
            }
            throw new Exception();
        }

        public static void OrderByCourses(IEnumerable<Student> students)
        {
            var st = students.OrderBy(x => x.Course);
            foreach (Student item in st)
            {
                Console.WriteLine($"{item.Name}  {item.Surname} {item.Group} {item.Course}");
            }
        }

        public static void DisplayByAlphabet(IEnumerable<Person> persons)
        {
            var p = persons.OrderBy(x => x.Name).ThenBy(x => x.Surname);
            foreach (Person item in p)
            {
                Console.WriteLine($"{item.Name}  {item.Surname} ");
            }
        }


        public static void OrderByCoursesFromDep(Department department)
        {
            var d = department.Students.OrderBy(x=>x.Course);
            foreach (Student item in d)
            {
                Console.WriteLine($"{item.Name}  {item.Surname} {item.Group} {item.Course}");
            }

        }

    }
}
