using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplicaiton
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }
        private Cashier cashier;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            cashier = new Cashier("Airone Gamil", "Finance", userBox.Text, passBox.Text);

            if(cashier.validateLogin(userBox.Text, passBox.Text))
            {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment(), "Success", MessageBoxButtons.OK);
                Form1 form = new Form1();
                this.Hide();
                form.Show();

            }
            else
            {
                MessageBox.Show("Login Failed.", "Failed", MessageBoxButtons.OK);
            }
        }
    }
}
