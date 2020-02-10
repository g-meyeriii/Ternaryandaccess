using System;
using System.Collections.Generic;
using System.Text;

namespace Ternaryandaccess {
    
    public class Customer {


        //Properties
        private static int NextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }


        //methods
        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;
        }
        public Customer (string Name) {
                this.Id = NextId;
                this.Name = Name;
                NextId++;
            
        }

    }
}
