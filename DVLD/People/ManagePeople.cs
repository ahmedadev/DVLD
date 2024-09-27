using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
namespace DVLD.People
{
    public partial class ManagePeople : Form
    {

        public ManagePeople()
        {
            InitializeComponent();
            ctrlManage1.TableList = clsPerson.GetAllPeople();
            ctrlManage1.Title = "Manage People";
        }


    }
}
