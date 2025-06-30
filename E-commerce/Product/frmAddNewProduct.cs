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
    public partial class frmAddNewProduct: Form
    {
        public frmAddNewProduct()
        {
            InitializeComponent();
        }

        public frmAddNewProduct(int productID)
        {
            InitializeComponent();
            ctrlAddEditProduct1.fillForm(productID);
        }
    }
}
