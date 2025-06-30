using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce.Seller
{
    public partial class frmBecomeASeller: Form
    {
        public frmBecomeASeller()
        {
            InitializeComponent();
        }

        public frmBecomeASeller(int sellerID)
        {
            InitializeComponent();
            ctrlBecomeASeller1.FillForm(sellerID);
        }
    }
}
