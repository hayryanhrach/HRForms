using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRForms
{
    public partial class AllEmpForm : Form
    {
        public AllEmpForm()
        {
            InitializeComponent();
            this.txtAllEmp.Text = FileInfoTotxtAllEmp();
        }
        public string FileInfoTotxtAllEmp()
        {
            string FileInfo;
            StreamReader streamReader = new StreamReader("FileEmployee.txt");
            FileInfo = streamReader.ReadToEnd();
            streamReader.Close();
            FileInfo=FileInfo.Replace("#", "\r\n");
            FileInfo=FileInfo.Replace(",", ",     ");
            FileInfo=FileInfo.Replace("😀", "«Կոդ» - ");
            FileInfo=FileInfo.Replace("😆", "«Անուն» - ");
            FileInfo=FileInfo.Replace("😺", "«Ազգանուն» - ");
            FileInfo=FileInfo.Replace("🤪", "«Բաժնի անուն» - ");
            return FileInfo;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm= new MainForm();
            mainForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            AddForm addForm= new AddForm();
            addForm.Show();
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelateAll_Click(object sender, EventArgs e)
        {

        }
    }
}
