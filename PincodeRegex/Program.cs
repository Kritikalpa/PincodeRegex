using System;
using System.Text.RegularExpressions;

namespace PincodeRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            long pinCode = 400088;
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
