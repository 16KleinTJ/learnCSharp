using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class HeadTeacher : Person
    {
        List<HeadOfDepartment> headsOfDept;
        public HeadTeacher(String name, HeadOfDepartment headOfDept) : base(name, Person.type.HEADTEACHER)
        {
            this.headsOfDept.Add(headOfDept);
        }
    }
}
