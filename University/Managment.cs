using System;
using System.Collections.Generic;
using System.Dynamic;
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
    }
}
