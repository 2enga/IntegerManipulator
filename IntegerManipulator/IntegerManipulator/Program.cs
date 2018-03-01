using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace IntegerManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations myCalulations = new Calculations();

            using (StreamReader streamReader = new StreamReader(args[0])) // if running from visual studio, place file path here. Otherwise file path becomes command line arg
            {
                string myString;
                do
                {
                    myString = streamReader.ReadLine();

                    if (!string.IsNullOrWhiteSpace(myString) && (myString.All(Char.IsDigit))) //only parse if integers but does not handle the case if characters are different from integers
                    {
                        var list = myCalulations.getPrimes(Int32.Parse(myString));
                        Console.Write("\nPrime factorization of " + myString + " is : ");
                        Console.Write(String.Join(",", list.ToList()));
                    }
                } while (myString != null);
            }
            Console.ReadLine();
        }
    }
}
