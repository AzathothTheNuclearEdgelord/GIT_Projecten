using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Ask the user which conversion to make, either decimal -> binairy or binairy -> decimal.
// Find and program a solution for converting a decimal number e.g. 27 or 7 to a binary representation.
// Find and program a solution for converting a binairy number e.g. 101 or 01101101 to a decimal representation.
// Make sure user interaction and code is clean.

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputUser;

            float inputNumber = 0;
            float binaryNumber = 128;

            Console.WriteLine("Welcome to the converter.");
            Console.WriteLine("In here you convert a decimal to binary and also the other way around. it is converted to 8 bit");
            Console.ReadLine();
            Console.WriteLine("press 1: decimal -> binary. press 2: binary -> decimal");

            do
            {
                inputUser = Console.ReadLine();
            } while (!float.TryParse(inputUser, out inputNumber) || inputNumber > 2 || inputNumber < 1);

            Console.WriteLine();

            if (inputNumber == 1)
            {
                DecimalToBinary();
            }

            if (inputNumber == 2)
            {
                BinaryToDecimal();
            }

            void DecimalToBinary()
            {
                do
                {
                    Console.WriteLine("Choose a number to convert between 1 and 256");
                    inputUser = Console.ReadLine();
                } while (!float.TryParse(inputUser, out inputNumber) || inputNumber > 256 || inputNumber < 1);

                while (binaryNumber >= 1)
                {
                    if (inputNumber >= binaryNumber)
                    {
                        //Console.WriteLine(binairGetallen);
                        inputNumber = inputNumber - binaryNumber;
                        binaryNumber = binaryNumber * 0.5f;
                        Console.WriteLine("1");
                    }
                    else
                    {
                        //Console.WriteLine(binairGetallen);
                        binaryNumber = binaryNumber * 0.5f;
                        Console.WriteLine("0");
                    }
                }
            }

            void BinaryToDecimal()
            {
                float total;

                for (int i = 0; i < 8; i++)
                {
                    do
                    {
                        Console.WriteLine("Choose a 1 or a 0 to convert");
                        inputUser = Console.ReadLine();
                    } while (!float.TryParse(inputUser, out inputNumber) || inputNumber > 1 || inputNumber < 0);
                }
                
            }

            Console.ReadLine();
        }
    }
}
