using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoProject.View
{
    public partial class InfoForm : Form
    {
        private String gnrtdUverenie;
        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(String str)
        {
            InitializeComponent();
            gnrtdUverenie = str;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (infoTextBox.SelectedText == "")
                    infoTextBox.Font = fontDialog.Font;
                else
                    infoTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            infoTextBox.Text = gnrtdUverenie;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (infoTextBox.SelectedText == "")
                    infoTextBox.ForeColor = colorDialog1.Color;
                else
                    infoTextBox.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
