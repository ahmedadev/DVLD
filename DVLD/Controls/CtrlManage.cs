using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
namespace DVLD
{
    public partial class CtrlManage : UserControl
    {
        public DataTable TableList { set; get; }
        public string Title { set; get; }


        public CtrlManage()
        {

            InitializeComponent();
        }
        private void _RefreshTableList()
        {
            dgvManageTable.DataSource = TableList;
        }

        private void CtrlManage_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            _RefreshTableList();
        }

        private void dgvManageTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Show the context menu at the location of the mouse click
                cxtManageTable.Show(dgvManageTable, e.Location);
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Add New Person");
          
        }


        private void ShowDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Show Details Person");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Edit Person");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Delete Person");
        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Send Email Person");
        }

        private void SendCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Send Call Person");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew_Click(sender,e);
        }
    }
}
