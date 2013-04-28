using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoProject.Data;
 
namespace StudentInfoProject.Logic
{
    class LoginValidation
    {
        private string _username;
        private string _password;

        public LoginValidation(string username, string password)
        {
            _username = username;
            _password = password;
            errText = string.Empty;
        }

        public string errText { get; private set; }

        private bool isUsernameValid()
        {
            if (_username.Length == 0)
                return false;
            else return true;
        }

        private bool isPasswordValid()
        {
            if (_password.Length < 6)
                return false;
            else return true;
        }

        public bool ValidateUserInput(out User user)
        {
            User queryResult = UserData.IsUserPassCorrect(_username, _password);
            
            if (!isUsernameValid())
            {
                errText += "Полето за въвеждане на потребителско име е празно! ";
            }
            if (!isPasswordValid())
            {
                errText += "Паролата трябва да е минимум 6 символа! ";
            }
            if (queryResult == null)
            {
                errText += "Няма потребителско име с този USERNAME и PASSWORD! ";
            }
            if (errText.Length != 0)
            {
                user = null;
                return false;
            }
            else
            {
                user = queryResult;
                return true;
            }
        }
    }
}
