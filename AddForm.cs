using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRForms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        public static int IsIDNumber(TextBox x)
        {
            int ID = 0;
                try
                {
                    ID =int.Parse(x.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to Add: {ex.Message}", $"{x}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return ID;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee EmployeObj = new Employee(IsIDNumber(txtIDValue), txtFirsNameValue.Text, txtLastNameValue.Text, IsIDNumber(txtDepartmentValue));   
            StreamWriter streamWriter = new StreamWriter("FileEmployee.txt", true);
            streamWriter.Write("😀"+$"{EmployeObj.EmployeID}"+","+ "😆" + $"{EmployeObj.FirstName}"+","+ "😺" + $"{EmployeObj.LastName}"+","+ "🤪"+$"{EmployeObj.DepartmentID}"+"#"+"\n");
            streamWriter.Close();
            txtIDValue.Clear();
            txtFirsNameValue.Clear();
            txtLastNameValue.Clear();
            txtDepartmentValue.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtIDValue.Clear();
            txtFirsNameValue.Clear();
            txtLastNameValue.Clear();
            txtDepartmentValue.Clear();
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm =new MainForm();
            mainForm.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Close();
            AllEmpForm allEmpForm = new AllEmpForm();
            allEmpForm.Show();
        }
    }
}
