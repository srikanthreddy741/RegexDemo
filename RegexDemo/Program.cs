using System;

namespace RegexDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //    Console.WriteLine(" enter the pincode");

            //    string pin=Console.ReadLine();

            //    bool val = Pincode.ValidatePincode(pin);

            //    if(val)
            //    {
            //        Console.WriteLine("pincode is correct");

            //    }
            //    else
            //    {
            //        Console.WriteLine("pincode is incorrect");
            //    }
            //}
            Console.WriteLine(" enter the phone number");

            string pin = Console.ReadLine();

            bool val = phonenumber.ValidatePhonenumber(pin);

            if (val)
            {
                Console.WriteLine("phonenumber is correct");

            }
            else
            {
                Console.WriteLine("phonenumber is incorrect");
            }
        }
    }
}
