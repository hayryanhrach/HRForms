using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRForms
{
    public class Department
    {
        public int DepartamentID { get; set; }
        public string Name { get; set; }

        public Department(int DID, string N)
        {
            DepartamentID = DID;
            Name = N;
        }
    }

}
