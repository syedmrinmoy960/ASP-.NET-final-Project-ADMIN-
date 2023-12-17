using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpUserName { get; set; }
        public string EmpPassword { get; set; }
        public string EmpEmail { get; set; }
        public string EmpNid { get; set; }
        public string EmpContract { get; set; }
        public System.DateTime EmpDOB { get; set; }
    }
}
