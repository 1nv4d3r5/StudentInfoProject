using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StudentInfoProject.Data
{
    class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) &&
                               (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
                return queryResult.ElementAt<User>(0);
            else
                return null;
        }

        public static Student GetStudentData(string facNum)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               where students.FacNumber == facNum
                               select students).ToArray<Student>();
            return queryResult.ElementAt<Student>(0);
        }

        public static bool AddStudent(Student std)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            try
            {
                dc.AddNewStudent(std.FirstName, std.SecondName, std.LastName, std.Faculty, std.Specialty, std.OKS,
                    std.StudentStatus, std.FacNumber, std.Course, std.Potok, std.Group);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool AddUser(Student std)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            try
            {
                dc.AddNewUser(std.FacNumber, std.FacNumber, std.FacNumber);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
