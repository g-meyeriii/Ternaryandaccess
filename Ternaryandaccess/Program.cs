using System;

namespace Ternaryandaccess {
    public class Program {
       
        
        static void Main(string[] args) {

            var message = Customer.PrintNextId();
            Console.WriteLine(message);
            
            public override bool Equals(object obj) {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        //// override object.GetHashCode
        //public override int GetHashCode() {
        //    // TODO: write your implementation of GetHashCode() here
        //    throw new NotImplementedException();
        //    return base.GetHashCode();
        //}
    }
            var cust1 = new Customer ("Max Tech Training");
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");

            cust1.NationalAccount("yes");

            var order1 = new Order { Id = 1, Amount = 1000, customer = cust1 };

        }
        static internal Cubed(int nbr) {
    return nbr * nbr * nbr;
        }
    }


}
