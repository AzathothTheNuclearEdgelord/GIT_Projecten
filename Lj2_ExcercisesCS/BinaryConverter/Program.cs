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
            // user input.
            string inputUser;

            // numbers inputted by the user.
            float inputNumber = 0;
            int binaryNumber = 128;

            // introduction converter and choose a convertion.
            Console.WriteLine("Welcome to the converter.");
            Console.WriteLine("In here you convert a decimal to binary and also the other way around. it is converted to 8 bit");
            Console.ReadLine();
            Console.WriteLine("press 1: decimal -> binary. press 2: binary -> decimal");

            // input a decimal.
            do
            {
                inputUser = Console.ReadLine();
            } while (!float.TryParse(inputUser, out inputNumber) || inputNumber > 2 || inputNumber < 1);

            Console.WriteLine();

            // if you input 1 you go to from decimal to binary
            if (inputNumber == 1)
            {
                DecimalToBinary();
            }

            // if you input 2 you go to from binary to decimal
            if (inputNumber == 2)
            {
                BinaryToDecimal();
            }

            // this method converts a decimal number to a binary number in 8 bit
            void DecimalToBinary()
            {
                // input user
                do
                {
                    Console.WriteLine("Choose a number to convert between 1 and 255");
                    inputUser = Console.ReadLine();
                } while (!float.TryParse(inputUser, out inputNumber) || inputNumber > 255 || inputNumber < 1);

                while (binaryNumber >= 1)
                {
                    if (inputNumber >= binaryNumber)
                    {
                        //Console.WriteLine(binairGetallen);
                        inputNumber = inputNumber - binaryNumber;
                        binaryNumber = binaryNumber / 2;
                        Console.WriteLine("1");
                    }
                    else
                    {
                        //Console.WriteLine(binairGetallen);
                        binaryNumber = binaryNumber / 2;
                        Console.WriteLine("0");
                    }
                }
            }

            void BinaryToDecimal()
            {
                // a array of binary digits
                int[] binaryDigits = new int[8];

                // a total that becomes a decimal
                float total = 0;

                // i this for loop you input all binary numbers
                for (int i = 0; i < 8; i++)
                {
                    do
                    {
                        Console.WriteLine("Type in a 1 or a 0");
                        inputUser = Console.ReadLine();
                        Console.WriteLine();
                    } while (!int.TryParse(inputUser, out binaryDigits[i]) || binaryDigits[i] < 0 || binaryDigits[i] > 1);
                }

                // all binary numbers in a row
                Console.WriteLine("Your choosen digits are:");
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(binaryDigits[i]); 
                }

                Console.ReadLine();

                // the decimal that comes out
                Console.WriteLine("Your decimal number is:");
                for (int i = 0; i < 8; i++)
                {
                    if (binaryDigits[i] == 1)
                    {
                        total = total + binaryNumber;
                        binaryNumber = binaryNumber / 2;
                    }
                    else
                    {
                        binaryNumber = binaryNumber / 2;
                    }
                }

                Console.WriteLine(total);
            }

            Console.ReadLine();
        }
    }
}
