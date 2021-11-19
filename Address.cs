using System;

namespace BankConsole51
{
    public class Address{

        public string Street { get; set; }
        public string Apt { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Zip { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{Street}\n{Apt}\n{City}, {State} {Zip}";
            }
        }


    }
}