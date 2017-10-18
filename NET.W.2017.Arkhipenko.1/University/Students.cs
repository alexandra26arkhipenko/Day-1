using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public  class Students
    {
        public string Name { get; set; }
        public string Faculty { get; set; }

        public Students(string name, string faculty)
        {
            this.Name = name;
            this.Faculty = faculty;
        }

        public override string ToString()
        {
            return string.Format("Студент {0} учится на факультете : {1}", Name, Faculty);
        }
    }
}
