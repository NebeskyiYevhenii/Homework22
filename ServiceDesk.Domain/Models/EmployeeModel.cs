﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDesk.Domain.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        //public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
    }
}
