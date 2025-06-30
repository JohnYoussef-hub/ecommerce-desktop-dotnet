using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce.Product
{
    public partial class frmShowProductInformation: Form
    {
        public frmShowProductInformation()
        {
            InitializeComponent();
        }

        public frmShowProductInformation(int productID)
        {
            InitializeComponent();
            ctrlShowProductInformation1.fillForm(productID);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
