using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoProject.Data; 


namespace StudentInfoProject.Logic
{
    class StudentValidation
    {
        public Student IsThereStudent(User usr)
        {
            return UserData.GetStudentData(usr.FacNumver);
        }

        public bool InsertStudent(Student std)
        {
            return UserData.AddStudent(std);
        }

        public bool InsertUser(Student std)
        {
            return UserData.AddUser(std);
        }
    }
}
