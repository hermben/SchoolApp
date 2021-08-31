using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum Gradelevels { Freshman, Sophomore, Junior, Senior }
        public Gradelevels Gradelevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        public override string Sendmessage(string message)
        {
            var original = base.Sendmessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This is a private and confidential.");
            return sb.ToString();
        }
    }
}
