using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplicaiton
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity) 
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.discounted_price = discount;
        }

        //Getting the total price
        public override double getTotalPrice()
        {
            item_discount = discounted_price * 0.01;
            discounted_price = item_price - (item_price * item_discount);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        //Settings the change input
        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }


        //Computing the change
        public double getChange()
        {
            change = payment_amount - total_price;
            return change;
        }
    }
}
