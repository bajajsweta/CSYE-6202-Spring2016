using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public class StudentInfo : EventArgs
    {
        public string StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string DeptType { get; set; }
        public string EnrollmentType { get; set; }


        public StudentInfo(string studentID, string firstName, string lastName, string department, string enrollmentType)
        {
            StudentID = studentID;
            StudentFirstName = firstName;
            StudentLastName = lastName;
            DeptType = department;
            EnrollmentType = enrollmentType;
        }

        public override string ToString()
        {
            return string.Format("StudentID: {0}, FirstName: {1}, LastName: {2}, Department: {3}, EnrollmentType: {4}", StudentID, StudentFirstName, StudentLastName, DeptType, EnrollmentType);
        }


    }
}
