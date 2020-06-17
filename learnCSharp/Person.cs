using System;
using System.Collections.Generic;
using System.Text;

namespace learnCSharp
{
    class Person
    {
        public enum type
        {
            TEACHER,
            PUPIL,
            HEADOFDEPT,
            HEADTEACHER
        };
        protected type pType;

        public enum colour
        {
            BLUE, BROWN, HAZEL, GREEN, RED,
        };
        public colour eyeColour { get; set; }

        public String name { get; }
        public Person(String name, type pType)
        {
            this.name = name;
            this.pType = pType;
        }


    }
}
