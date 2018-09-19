using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudyLab1Math
{
    class Program
    {
        static void Main(string[] args)
        {
            char checkN;
            bool runP = true;
            {
                Console.WriteLine("Please enter a number.");
                int firstNumber = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("You entered: {0}, Please enter another number with the same number of digits.",
                    firstNumber);
                int secondNumber = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("You entered {0} and {1}, " +
                    "Shall we check if their corresponding numbers sum to the same total? (Y or N)",
                    firstNumber, secondNumber);

                checkN = Convert.ToChar(Console.ReadLine());

                if (checkN != 'y' && checkN != 'Y')
                {
                    runP = false;
                }
                else
                    runP = true;

                int[] firstNumberArray = firstNumber.ToString().Select(o => Convert.ToInt32(o)).ToArray();
                int[] secondNumberArray = secondNumber.ToString().Select(o => Convert.ToInt32(o)).ToArray();

                while (runP == true)

                {
                    for (int i = 1; i < firstNumberArray.Length; i++)
                    {
                        if (firstNumberArray[0] + secondNumberArray[0] != firstNumberArray[i] + secondNumberArray[i])
                        {
                            Console.WriteLine("Oh no! Your numbers corresponding numbers" +
                                " do not sum to the same total.");
                            Console.ReadLine();
                            return;
                        }
                        else
                            Console.WriteLine("Congratulations, your numbers corresponding numbers" +
                                " sum to the same total.");
                        Console.ReadLine();
                        return;
                    }
                }
            }
        }
    }
}
