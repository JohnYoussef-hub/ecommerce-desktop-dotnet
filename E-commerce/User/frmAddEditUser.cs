using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce.User
{
    public partial class frmAddEditUser: Form
    {
        public frmAddEditUser()
        {
            InitializeComponent();
        }

        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            ctrlAddEditUser1.FillForm(userID);
        }
    }
}
