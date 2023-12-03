using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workforce_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
            searchEmployee1.Visible = false;


            Salary salaryForm = salary1 as Salary;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            searchEmployee1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
            searchEmployee1.Visible = false;

            AddEmployee addEmForm = addEmployee1 as AddEmployee;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                    , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
            
        }

        private void addEmployee1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            searchEmployee1.Visible = true;


            Salary salaryForm = salary1 as Salary;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
