using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLAyer;
using EntityLayer;
using LogiccLayer;

namespace LayeredArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            List<EntityEmployee> emp = LogiccLayer.LogiccEmployee.LLEmployeeList();
            dataGridView1.DataSource = emp;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EntityEmployee emp = new EntityEmployee();
            emp.Name = textBoxName.Text;
            emp.Surname = textBoxSurname.Text;
            emp.City = textBoxCity.Text;
            emp.Duty = textBoxDuty.Text;
            emp.Salary = (short)Convert.ToInt32(textBoxSalary.Text);
            LogiccLayer.LogiccEmployee.LLAddEmployee(emp);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            LogiccLayer.LogiccEmployee.LLDeleteEmployee(id);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EntityEmployee emp = new EntityEmployee();

            emp.Id = Convert.ToInt32(textBoxId.Text);
            emp.Name = textBoxName.Text;
            emp.Surname = textBoxSurname.Text;
            emp.Duty = textBoxDuty.Text;
            emp.Duty = textBoxCity.Text;
            emp.Salary = (short)Convert.ToInt32(textBoxSalary.Text);

            LogiccEmployee.LLUpdateEmployee(emp);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row1 = dataGridView1.Rows[row];

            textBoxId.Text = row1.Cells[0].Value.ToString();
            textBoxName.Text = (string)row1.Cells[1].Value;
            textBoxSurname.Text = (string)row1.Cells[2].Value;
            textBoxCity.Text = (string)row1.Cells[3].Value;
            textBoxDuty.Text = (string)row1.Cells[4].Value;
            textBoxSalary.Text = row1.Cells[5].Value.ToString();
        }
    }
}
