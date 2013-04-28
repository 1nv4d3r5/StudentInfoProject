using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoProject.Data;
using StudentInfoProject.Logic;

namespace StudentInfoProject.View
{
    public partial class MainForm : Form
    {
        StudentValidation sv = new StudentValidation();
        public UserStatus userStatus { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            userStatus = UserStatus.ANONYMOUS;
            getStatus(userStatus);
        }

        public void eraseData()
        {
            tbFirstName.Text = "";
            tbSecondName.Text = "";
            tbLastName.Text = "";

            tbFacultyName.Text = "";
            tbSpecialty.Text = "";
            cbOKS.SelectedIndex = 0;
            cbStudentStatus.SelectedIndex = 0;
            tbFacNumber.Text = "";

            tbFlow.Text = "";
            numCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            tbGroup.Text = "";
        }

        public void ShowStudentInfo(Student student) // This method will read the student information from the database. It will be coded later.
        {
            btnUverenie.Visible = true;
            photoDialogButton.Enabled = true;
            miLogInOut.Text = "Logout";
            tbFirstName.Text = student.FirstName;
            tbSecondName.Text = student.SecondName;
            tbLastName.Text = student.LastName;

            tbFacultyName.Text = student.Faculty;
            tbSpecialty.Text = student.Specialty;
            cbOKS.SelectedIndex = student.OKS;
            cbStudentStatus.SelectedIndex = student.StudentStatus;
            tbFacNumber.Text = student.FacNumber;

            tbFlow.Text = student.Potok;
            numCourse.Value = student.Course;
            tbGroup.Text = student.Group.ToString();
        }

        public void disableControls()
        {
            btnUverenie.Visible = false;
            photoDialogButton.Enabled = false;
            tbFirstName.Enabled = false;
            tbSecondName.Enabled = false;
            tbLastName.Enabled = false;

            tbFacultyName.Enabled = false;
            tbSpecialty.Enabled = false;
            cbOKS.Enabled = false;
            cbStudentStatus.Enabled = false;
            tbFacNumber.Enabled = false;

            tbFlow.Enabled = false;
            numCourse.Enabled = false;
            tbGroup.Enabled = false;
            insertStudentButton.Visible = false;
        }

        public void enableControls()
        {
            miLogInOut.Text = "Logout";
            photoDialogButton.Enabled = true;
            tbFirstName.Enabled = true;
            tbSecondName.Enabled = true;
            tbLastName.Enabled = true;

            tbFacultyName.Enabled = true;
            tbSpecialty.Enabled = true;
            cbOKS.Enabled = true;
            cbStudentStatus.Enabled = true;
            tbFacNumber.Enabled = true;

            tbFlow.Enabled = true;
            numCourse.Enabled = true;
            tbGroup.Enabled = true;
            insertStudentButton.Visible = true;
        }

        public void getStatus(UserStatus usrStatus)
        {
            lblUserStatus.Text = usrStatus.ToString();
            switch (usrStatus)
            {
                case UserStatus.ANONYMOUS:
                    disableControls();
                    break;
                case UserStatus.STUDENT:
                    try
                    {
                        Student student;
                        student = sv.IsThereStudent(LoginForm.user);
                        ShowStudentInfo(student);
                    }
                    catch (NullReferenceException)
                    {
                    }
                    break;
                case UserStatus.ADMIN:
                    enableControls();
                    insertStudentButton.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void miLogInOut_Click(object sender, EventArgs e)
        {
            if (miLogInOut.Text == "Login")
            {
                LoginForm lgnForm = new LoginForm();
                lgnForm.FormClosed += new FormClosedEventHandler(LoginFormClosed);
                lgnForm.ShowDialog();
            }
            else if (miLogInOut.Text == "Logout")
            {
                miLogInOut.Text = "Login";
                disableControls();
                userStatus = UserStatus.ANONYMOUS;
                getStatus(userStatus);
                eraseData();
            }
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abBox = new AboutBox();
            abBox.ShowDialog();
        }

        private string GenerateInfoText()
        {
            string text = "Уверение\n";
            text += tbFirstName.Text + " " + tbSecondName.Text + " " +
           tbLastName.Text;
            text += " е студент/ка във Факултет " + tbFacultyName.Text +
           ", специалност " + tbSpecialty.Text;
            text += "\n";
            return text;
        }

        private void LoginFormClosed(object sender, EventArgs e)
        {
            try
            {
                if (LoginForm.user.Role == 1)
                    userStatus = UserStatus.ANONYMOUS;
                else if (LoginForm.user.Role == 2)
                    userStatus = UserStatus.STUDENT;
                else if (LoginForm.user.Role == 3)
                    userStatus = UserStatus.ADMIN;
                getStatus(userStatus);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudentPhoto();
        }

        public void LoadStudentPhoto()
        {
            if (studentPhotoDialog.ShowDialog() == DialogResult.OK)
                pbStudentPhoto.ImageLocation = studentPhotoDialog.FileName;
        }

        private void insertStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = tbFirstName.Text;
            student.SecondName = tbSecondName.Text;
            student.LastName = tbLastName.Text;
            student.Faculty = tbFacultyName.Text;
            student.Specialty = tbSpecialty.Text;
            student.FacNumber = tbFacNumber.Text;
            student.OKS = (short)cbOKS.SelectedIndex;
            student.StudentStatus = (short)cbStudentStatus.SelectedIndex;
            student.Course = (short)numCourse.Value;
            student.Potok = tbFlow.Text;
            student.Group = tbGroup.Text;
            if (sv.InsertStudent(student) && sv.InsertUser(student))
                MessageBox.Show("Студентът беше добавен успешно!");
            else
                MessageBox.Show("Възникна проблем по време на записа!");
        }

        private void btnUverenie_Click(object sender, EventArgs e)
        {
            String text = GenerateInfoText();
            InfoForm infoForm = new InfoForm(text);
            infoForm.Show();
        }



    }
}
