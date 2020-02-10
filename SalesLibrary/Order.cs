using System;
using System.Collections.Generic;
using System.Text;

namespace Ternaryandaccess {
    public class Order {
    //Properties
    public int Id { get; set; }
    public double Amount { get; set; }
    public Customer customer { get; set; }

        public void SetCustomer(Customer customer) {

        }
    }
}
