using System;

namespace ATMProgram
{
    class ATMMain
    {
        static void Main(string[] args)
        {
            string answerExit = "";
            do
            {
                int isPin = 2020;

                Console.WriteLine("\nWELCOME TO ATM SERVICE");
                Console.WriteLine("Enter your PIN:");
                isPin = Int32.Parse(Console.ReadLine());
               
                if (isPin == 2020)
                {
                    System ATM = new System();
                    ATM.menu();
                }
                else
                {
                    Console.WriteLine("PIN incorrect");
                }
 

                do
            {
                Console.WriteLine("Exit? (YES/NO)");
                    answerExit = Console.ReadLine();
                } while (answerExit.ToLower() != "yes" && answerExit.ToLower() != "no");
            //------------------------------------------------------//

        } while (answerExit.ToLower() != "yes");
        }
        
    }
}
