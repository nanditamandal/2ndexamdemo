using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customerdetail.Model;
using Customerdetail.BLL;

namespace Customerdetail
{
    public partial class Customer : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public Customer()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
         
            CustomerModel customerModel=new CustomerModel();

            customerModel.Code = codeTextBox.Text;

            bool isExit = _customerManager.Exitcode(customerModel);
            if (isExit)
            {
                MessageBox.Show(codeTextBox.Text + " all ready exit...");
                return;
            }

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }

            customerModel.Name = nameTextBox.Text;

            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("address Can not be Empty!!!");
                return;
            }
            customerModel.Address = addressTextBox.Text;

            

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("contact Can not be Empty!!!");
                return;
            }
            customerModel.Contact = contactTextBox.Text;
            bool hascontact = _customerManager.Exitcontact(customerModel);
            if (hascontact)
            {
                MessageBox.Show(contactTextBox.Text + " all ready exit...");
                return;
            }

            if (String.IsNullOrEmpty(districtComboBox.Text))
            {
                MessageBox.Show("district Can not be Empty!!!");
                return;
            }

            customerModel.District = districtComboBox.Text;

            bool add = _customerManager.Addcustomer(customerModel);
            if (add)
            {
                MessageBox.Show("add successfull..");

            }
            else
            {
                MessageBox.Show("add false..");
            }



        }
    }
}
