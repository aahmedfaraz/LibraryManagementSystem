using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    class Faculty
    {
        protected static Faculty faculty;
        public int FacultyID;
        public string FacultyName;
        public string FacultyEmail;
        public string FacultyPassword;
        public string FacultyQualification;
        public string FacultyHiredate;
        public string FacultyType;
        private Faculty(int FacultyID, string FacultyName, string FacultyEmail, string FacultyPassword, string FacultyQualification, string FacultyHiredate, string FacultyType)
        {
            this.FacultyID = FacultyID;
            this.FacultyName = FacultyName;
            this.FacultyEmail = FacultyEmail;
            this.FacultyPassword = FacultyPassword;
            this.FacultyQualification = FacultyQualification;
            this.FacultyHiredate = FacultyHiredate;
            this.FacultyType = FacultyType;
        }
        public static Faculty GetFaculty(int FacultyID, string FacultyName, string FacultyEmail, string FacultyPassword, string FacultyQualification, string FacultyHiredate, string FacultyType)
        {
            if(faculty == null)
            {
                faculty = new Faculty(FacultyID, FacultyName, FacultyEmail, FacultyPassword, FacultyQualification, FacultyHiredate, FacultyType);
            }
            return faculty;
        }
    }
}
