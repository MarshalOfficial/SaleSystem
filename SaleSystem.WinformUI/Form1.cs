using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleSystemCore.Logic;
namespace SaleSystem.WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // just for test
            //var cash = Cash.LoginUser("admin", "admin");
            //var user = Cash._User;
            //var perms = Cash._UserPermissionses;
            //var users = Cash._UserModule.GetAllUsers();
        }       

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
