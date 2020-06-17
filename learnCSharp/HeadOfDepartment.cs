using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class HeadOfDepartment : Person
    {
        List<Teacher> teachers;
        public HeadOfDepartment(String name, Teacher teacher) : base(name, Person.type.HEADOFDEPT)
        {
            this.teachers.Add(teacher);
        }
    }
}
