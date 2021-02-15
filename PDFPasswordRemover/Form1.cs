using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFPasswordRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_File_Select_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Input_File_Select_Description.ForeColor = Color.Black;
            Input_File_Select_FileName.Text = openFileDialog1.FileName;
        }

        private void Mode_Choosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode_Choosing_Description.ForeColor = Color.Black;
            if (Mode_Choosing.SelectedIndex == 0)
            {
                Password_Enter_Panel.Visible = true;
                Password_Enter_Description.Text = "Please input the user password.";
            }
            if (Mode_Choosing.SelectedIndex == 1)
            {
                Password_Enter_Panel.Visible = true;
                Password_Enter_Description.Text = "Please input the owner password.";
            }
            if (Mode_Choosing.SelectedIndex == 2)
            {
                Password_Enter_Panel.Visible = false;
            }
        }

        private void Password_Enter_Click(object sender, EventArgs e)
        {
            Password_Enter.Text = "";
            Password_Enter_Description.ForeColor = Color.Black;
        }

        private void Password_Enter_Leave(object sender, EventArgs e)
        {
            if (Password_Enter.Text == "")
            {
                Password_Enter.Text = "Enter Password";
                Password_Enter_Description.ForeColor = Color.Red;
            }
        }

        private void Mode_Choosing_Leave(object sender, EventArgs e)
        {
            if (Mode_Choosing.SelectedIndex == -1)
            {
                Mode_Choosing_Description.ForeColor = Color.Red;
            }
        }
    }
}
