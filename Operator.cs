using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            Console.WriteLine("Input secret numbers : ");
            String number2 = Console.ReadLine();
            Console.WriteLine("Input secret code : ");
            string code = Console.ReadLine();
            int number = Convert.ToInt32(number2);
            if (code == "CIA")
            {
                if (number2[5]%3 == 0) 
                {
                    if (number2[4] != '1'&&number2[4] != '3' && number2[4] != '5' && number2[2] >= 6 && number2[2] != 8)
                    {
                        result = true;

                    }
                }
            }
            if (code == "FBI")
            {
                if (number2[0] >= 4 && number2[0] != 8 && number2[0] != 9)
                {
                    if (number2[3] % 2 == 0 && number2[3] != 6)
                    {
                        if (number2[1]%2 != 0)
                        {
                            result = true;
                        }
                    }
                }
            }
            if (code == "NSA")
            {
                if ((number2[5] == '2' )||( number2[5] == '3' )|| (number2[5] == '5'))
                {
                    if (number2[3] % 3 == 0 && number2[3] %2 != 0)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (number2[i] == '7')
                            {
                                result = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
