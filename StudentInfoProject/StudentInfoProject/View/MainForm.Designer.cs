namespace StudentInfoProject.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fmiSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStudentInfo = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.insertStudentButton = new System.Windows.Forms.Button();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.lblUserStatusText = new System.Windows.Forms.Label();
            this.photoDialogButton = new System.Windows.Forms.Button();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.tbFlow = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblFlow = new System.Windows.Forms.Label();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.lblCourse = new System.Windows.Forms.Label();
            this.tbFacNumber = new System.Windows.Forms.TextBox();
            this.cbStudentStatus = new System.Windows.Forms.ComboBox();
            this.cbOKS = new System.Windows.Forms.ComboBox();
            this.lblFacNumber = new System.Windows.Forms.Label();
            this.lblOKS = new System.Windows.Forms.Label();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.tbSpecialty = new System.Windows.Forms.TextBox();
            this.tbFacultyName = new System.Windows.Forms.TextBox();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbStudentPhoto = new System.Windows.Forms.GroupBox();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.studentPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnUverenie = new System.Windows.Forms.Button();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            this.tabControlStudentInfo.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.gbPersonalData.SuspendLayout();
            this.gbStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEdit,
            this.miView,
            this.miHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(654, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuMain";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLogInOut,
            this.miNew,
            this.fmiSeparator,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.ShortcutKeyDisplayString = "";
            this.miFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.miFile.ShowShortcutKeys = false;
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miLogInOut
            // 
            this.miLogInOut.Name = "miLogInOut";
            this.miLogInOut.Size = new System.Drawing.Size(104, 22);
            this.miLogInOut.Text = "Login";
            this.miLogInOut.Click += new System.EventHandler(this.miLogInOut_Click);
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(104, 22);
            this.miNew.Text = "New";
            // 
            // fmiSeparator
            // 
            this.fmiSeparator.Name = "fmiSeparator";
            this.fmiSeparator.Size = new System.Drawing.Size(101, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(104, 22);
            this.miExit.Text = "Exit";
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(39, 20);
            this.miEdit.Text = "Edit";
            // 
            // miView
            // 
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(44, 20);
            this.miView.Text = "View";
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControlStudentInfo
            // 
            this.tabControlStudentInfo.Controls.Add(this.tabStudent);
            this.tabControlStudentInfo.Controls.Add(this.tabMarks);
            this.tabControlStudentInfo.Location = new System.Drawing.Point(12, 27);
            this.tabControlStudentInfo.Name = "tabControlStudentInfo";
            this.tabControlStudentInfo.SelectedIndex = 0;
            this.tabControlStudentInfo.Size = new System.Drawing.Size(628, 345);
            this.tabControlStudentInfo.TabIndex = 1;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.btnUverenie);
            this.tabStudent.Controls.Add(this.insertStudentButton);
            this.tabStudent.Controls.Add(this.lblUserStatus);
            this.tabStudent.Controls.Add(this.lblUserStatusText);
            this.tabStudent.Controls.Add(this.photoDialogButton);
            this.tabStudent.Controls.Add(this.gbStudentInfo);
            this.tabStudent.Controls.Add(this.gbPersonalData);
            this.tabStudent.Controls.Add(this.gbStudentPhoto);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(620, 319);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Студент";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // insertStudentButton
            // 
            this.insertStudentButton.Location = new System.Drawing.Point(37, 256);
            this.insertStudentButton.Name = "insertStudentButton";
            this.insertStudentButton.Size = new System.Drawing.Size(140, 23);
            this.insertStudentButton.TabIndex = 6;
            this.insertStudentButton.Text = "Добави Студент";
            this.insertStudentButton.UseVisualStyleBackColor = true;
            this.insertStudentButton.Visible = false;
            this.insertStudentButton.Click += new System.EventHandler(this.insertStudentButton_Click);
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(78, 300);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(0, 13);
            this.lblUserStatus.TabIndex = 5;
            // 
            // lblUserStatusText
            // 
            this.lblUserStatusText.AutoSize = true;
            this.lblUserStatusText.Location = new System.Drawing.Point(7, 300);
            this.lblUserStatusText.Name = "lblUserStatusText";
            this.lblUserStatusText.Size = new System.Drawing.Size(65, 13);
            this.lblUserStatusText.TabIndex = 4;
            this.lblUserStatusText.Text = "User Status:";
            // 
            // photoDialogButton
            // 
            this.photoDialogButton.Location = new System.Drawing.Point(37, 184);
            this.photoDialogButton.Name = "photoDialogButton";
            this.photoDialogButton.Size = new System.Drawing.Size(140, 23);
            this.photoDialogButton.TabIndex = 3;
            this.photoDialogButton.Text = "Изберете снимка";
            this.photoDialogButton.UseVisualStyleBackColor = true;
            this.photoDialogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.tbGroup);
            this.gbStudentInfo.Controls.Add(this.tbFlow);
            this.gbStudentInfo.Controls.Add(this.lblGroup);
            this.gbStudentInfo.Controls.Add(this.lblFlow);
            this.gbStudentInfo.Controls.Add(this.numCourse);
            this.gbStudentInfo.Controls.Add(this.lblCourse);
            this.gbStudentInfo.Controls.Add(this.tbFacNumber);
            this.gbStudentInfo.Controls.Add(this.cbStudentStatus);
            this.gbStudentInfo.Controls.Add(this.cbOKS);
            this.gbStudentInfo.Controls.Add(this.lblFacNumber);
            this.gbStudentInfo.Controls.Add(this.lblOKS);
            this.gbStudentInfo.Controls.Add(this.lblStudentStatus);
            this.gbStudentInfo.Controls.Add(this.lblSpecialty);
            this.gbStudentInfo.Controls.Add(this.tbSpecialty);
            this.gbStudentInfo.Controls.Add(this.tbFacultyName);
            this.gbStudentInfo.Controls.Add(this.lblFacultyName);
            this.gbStudentInfo.Location = new System.Drawing.Point(214, 121);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(400, 180);
            this.gbStudentInfo.TabIndex = 2;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студентска информация";
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(308, 80);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(70, 20);
            this.tbGroup.TabIndex = 15;
            // 
            // tbFlow
            // 
            this.tbFlow.Location = new System.Drawing.Point(308, 54);
            this.tbFlow.Name = "tbFlow";
            this.tbFlow.Size = new System.Drawing.Size(70, 20);
            this.tbFlow.TabIndex = 14;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(261, 83);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 13;
            this.lblGroup.Text = "Група:";
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFlow.Location = new System.Drawing.Point(254, 55);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(46, 15);
            this.lblFlow.TabIndex = 12;
            this.lblFlow.Text = "Поток:";
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(308, 29);
            this.numCourse.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(70, 20);
            this.numCourse.TabIndex = 11;
            this.numCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCourse.Location = new System.Drawing.Point(264, 31);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(36, 15);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Курс:";
            // 
            // tbFacNumber
            // 
            this.tbFacNumber.Location = new System.Drawing.Point(100, 134);
            this.tbFacNumber.Name = "tbFacNumber";
            this.tbFacNumber.Size = new System.Drawing.Size(121, 20);
            this.tbFacNumber.TabIndex = 9;
            // 
            // cbStudentStatus
            // 
            this.cbStudentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentStatus.FormattingEnabled = true;
            this.cbStudentStatus.Items.AddRange(new object[] {
            "Държавна поръчка",
            "Платено обучение"});
            this.cbStudentStatus.Location = new System.Drawing.Point(100, 107);
            this.cbStudentStatus.Name = "cbStudentStatus";
            this.cbStudentStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStudentStatus.TabIndex = 8;
            // 
            // cbOKS
            // 
            this.cbOKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOKS.FormattingEnabled = true;
            this.cbOKS.Items.AddRange(new object[] {
            "Бакалавър",
            "Магистър"});
            this.cbOKS.Location = new System.Drawing.Point(100, 80);
            this.cbOKS.Name = "cbOKS";
            this.cbOKS.Size = new System.Drawing.Size(121, 21);
            this.cbOKS.TabIndex = 7;
            // 
            // lblFacNumber
            // 
            this.lblFacNumber.AutoSize = true;
            this.lblFacNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFacNumber.Location = new System.Drawing.Point(20, 135);
            this.lblFacNumber.Name = "lblFacNumber";
            this.lblFacNumber.Size = new System.Drawing.Size(74, 15);
            this.lblFacNumber.TabIndex = 4;
            this.lblFacNumber.Text = "Фак. номер";
            // 
            // lblOKS
            // 
            this.lblOKS.AutoSize = true;
            this.lblOKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOKS.Location = new System.Drawing.Point(59, 81);
            this.lblOKS.Name = "lblOKS";
            this.lblOKS.Size = new System.Drawing.Size(35, 15);
            this.lblOKS.TabIndex = 2;
            this.lblOKS.Text = "ОКС:";
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentStatus.Location = new System.Drawing.Point(44, 108);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(50, 15);
            this.lblStudentStatus.TabIndex = 3;
            this.lblStudentStatus.Text = "Статус:";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpecialty.Location = new System.Drawing.Point(7, 55);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(87, 15);
            this.lblSpecialty.TabIndex = 1;
            this.lblSpecialty.Text = "Специалност:";
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Location = new System.Drawing.Point(100, 54);
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Size = new System.Drawing.Size(121, 20);
            this.tbSpecialty.TabIndex = 6;
            // 
            // tbFacultyName
            // 
            this.tbFacultyName.Location = new System.Drawing.Point(100, 28);
            this.tbFacultyName.Name = "tbFacultyName";
            this.tbFacultyName.Size = new System.Drawing.Size(121, 20);
            this.tbFacultyName.TabIndex = 5;
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFacultyName.Location = new System.Drawing.Point(27, 29);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(67, 15);
            this.lblFacultyName.TabIndex = 0;
            this.lblFacultyName.Text = "Факултет:";
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.tbLastName);
            this.gbPersonalData.Controls.Add(this.tbSecondName);
            this.gbPersonalData.Controls.Add(this.tbFirstName);
            this.gbPersonalData.Controls.Add(this.lblLastName);
            this.gbPersonalData.Controls.Add(this.lblSecondName);
            this.gbPersonalData.Controls.Add(this.lblFirstName);
            this.gbPersonalData.Location = new System.Drawing.Point(214, 6);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(400, 109);
            this.gbPersonalData.TabIndex = 1;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Лични данни";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(100, 72);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(278, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(100, 46);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(278, 20);
            this.tbSecondName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(100, 20);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(278, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(29, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondName.Location = new System.Drawing.Point(32, 47);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(62, 15);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Презиме:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(59, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Име:";
            // 
            // gbStudentPhoto
            // 
            this.gbStudentPhoto.Controls.Add(this.pbStudentPhoto);
            this.gbStudentPhoto.Location = new System.Drawing.Point(6, 6);
            this.gbStudentPhoto.Name = "gbStudentPhoto";
            this.gbStudentPhoto.Size = new System.Drawing.Size(202, 172);
            this.gbStudentPhoto.TabIndex = 0;
            this.gbStudentPhoto.TabStop = false;
            this.gbStudentPhoto.Text = "Снимка";
            // 
            // tabMarks
            // 
            this.tabMarks.Location = new System.Drawing.Point(4, 22);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(620, 319);
            this.tabMarks.TabIndex = 1;
            this.tabMarks.Text = "Оценки";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // studentPhotoDialog
            // 
            this.studentPhotoDialog.FileName = "Изберете снимка";
            this.studentPhotoDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // btnUverenie
            // 
            this.btnUverenie.Location = new System.Drawing.Point(37, 220);
            this.btnUverenie.Name = "btnUverenie";
            this.btnUverenie.Size = new System.Drawing.Size(140, 23);
            this.btnUverenie.TabIndex = 7;
            this.btnUverenie.Text = "Създай уверение";
            this.btnUverenie.UseVisualStyleBackColor = true;
            this.btnUverenie.Click += new System.EventHandler(this.btnUverenie_Click);
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStudentPhoto.Image = global::StudentInfoProject.Properties.Resources.no_photo_male;
            this.pbStudentPhoto.InitialImage = null;
            this.pbStudentPhoto.Location = new System.Drawing.Point(31, 19);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(140, 140);
            this.pbStudentPhoto.TabIndex = 0;
            this.pbStudentPhoto.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 384);
            this.Controls.Add(this.tabControlStudentInfo);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационна система - СТУДЕНТ";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabControlStudentInfo.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            this.gbStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miLogInOut;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripSeparator fmiSeparator;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.TabControl tabControlStudentInfo;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.GroupBox gbStudentPhoto;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox tbFacNumber;
        private System.Windows.Forms.ComboBox cbStudentStatus;
        private System.Windows.Forms.ComboBox cbOKS;
        private System.Windows.Forms.Label lblFacNumber;
        private System.Windows.Forms.Label lblOKS;
        private System.Windows.Forms.Label lblStudentStatus;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox tbSpecialty;
        private System.Windows.Forms.TextBox tbFacultyName;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.TextBox tbFlow;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button photoDialogButton;
        private System.Windows.Forms.OpenFileDialog studentPhotoDialog;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Label lblUserStatusText;
        private System.Windows.Forms.Button insertStudentButton;
        private System.Windows.Forms.Button btnUverenie;
    }
}