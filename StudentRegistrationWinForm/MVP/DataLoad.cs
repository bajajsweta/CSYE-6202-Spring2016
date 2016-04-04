using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class DataLoad
    {

        public BindingList<StudentInfo> students = new BindingList<StudentInfo>();
        private List<string> deptType = new List<string>();
        private static readonly object syncLock = new object();
        private static readonly Random random = new Random();
        private static int rNumber;

        public BindingList<StudentInfo> loadlist() {
            students.Add(new StudentInfo(StudentIDRandomizer(), "Sweta","Sweta",DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Oliver", "Oliver", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Dhvani", "Dhvani", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Meha", "Meha", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Vishal", "Vishal", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Krishna", "Krishna", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Nikita", "Nikita", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "James", "James", DepartmentType(),  EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Kaush", "Kaush", DepartmentType(), EnrollmentType()));
            students.Add(new StudentInfo(StudentIDRandomizer(), "Maria", "Maria", DepartmentType(), EnrollmentType()));
            return students;
        }

        public static string StudentIDRandomizer()
        {
            const string chars = "123456789";
            string d;
            lock (syncLock)
            {
                string a = new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray());
                int aconv = Convert.ToInt32(a);
                int anew = aconv++;
                string b = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
                int bconv = Convert.ToInt32(b);
                int bnew = bconv++;
                string c = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
                int cconv = Convert.ToInt32(c);
                int cnew = cconv++;
                d = anew + "-" + bnew + "-" + cnew;
            }
            return d;
        }

        public static int EnrollRandomNumber()
        {
            const string chars = "12";
            lock (syncLock)
            { // synchronize
                string a = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
                rNumber = Convert.ToInt32(a);
            }
            return rNumber;
        }

        public string EnrollmentType()
        {
            string Enrolltype;
            if (rNumber == 1)
            { Enrolltype = "Full Time"; }
            else { Enrolltype = "Part Time"; }
            return Enrolltype;
        }


        public List<string> fillDeptType()
        {
            deptType.Add("Informations Systems");
            deptType.Add("International Affairs Systems");
            deptType.Add("Nursing Systems");
            deptType.Add("Pharmacy Systems");
            deptType.Add("Professional Studies Systems");
            return deptType;
        }

        public string DepartmentType() {
            const string chars = "12345";
            string v;
            string v1;
            lock (syncLock)
            { // synchronize
                 v = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
            }

            if (v == ("1") || v == ("2") || v == ("3") || v == ("3") || v == ("5"))
            { v1 = "Informations Systems"; }
            else { v1 = "Professional Studies Systems"; }
            return v1;
        }
    }
}
