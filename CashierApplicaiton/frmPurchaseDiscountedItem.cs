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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DiscountedItem discItem;
        
        //Computation of price
        private void computeButton_Click(object sender, EventArgs e)
        {
            discItem = new DiscountedItem(itemBox.Text, Convert.ToDouble(priceBox.Text), Convert.ToInt32(quantityBox.Text), Convert.ToDouble(discountBox.Text));

            string totalAmount = discItem.getTotalPrice().ToString();

            amountTotal.Text = totalAmount;
        }

        //Getting the change
        private void submitButton_Click(object sender, EventArgs e)
        {
            double totalPayment = Convert.ToDouble(paymentBox.Text);
            discItem.setPayment(totalPayment);
            changeTotal.Text = discItem.getChange().ToString();
        }
    }
}
