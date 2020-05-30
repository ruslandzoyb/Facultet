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
    }
}
