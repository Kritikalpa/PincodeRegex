using System;
using System.Text.RegularExpressions;

namespace PincodeRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the PIN code");
            string pinCode = Console.ReadLine();
            Regex reZip = new Regex("^[0-9]{6}$");
            if (reZip.IsMatch(pinCode.ToString()))
            {
                Console.WriteLine("Valid PIN Code");
            }
            else
            {
                Console.WriteLine("Invalid PIN Code");
            }
        }
    }
}
