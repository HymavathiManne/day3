using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice2_Day3.Models
{
    public class Empdept
    {
        Employee e1 = new Employee();
        public string Firstname
        {
            get
            {
                return e1.Firstname;
            }
            set
            {
                e1.Firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return e1.Lastname;
            }
            set
            {
                e1.Lastname = value;
            }
        }
        Department d1 = new Department();
        public string Deptname
        {
            get
            {
                return d1.Deptname;
            }
            set
            {
                d1.Deptname = value;
            }
        }
    }
}