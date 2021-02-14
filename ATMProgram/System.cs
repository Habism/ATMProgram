using System;

namespace ATMProgram
{
    class System
    {

        public void menu()
        {

            string answerExit = "";
            do
            {
                int isOption=0;
                String isAction;

            Console.WriteLine("Select Transaction: \n 1. Balance \n 2. Deposit \n 3. Withdraw");
            isAction = Console.ReadLine();

            if (isAction!=null && Number(isAction))
                {

                isOption = Int32.Parse(isAction);
                switch (isOption)
                {
                    case 1:
                        Methods.viewBalance(); break;
                    case 2:
                        Methods.Deposit(); break;
                    case 3:
                        Methods.Withdraw(); break;
                   /* case 4:
                        Console.WriteLine("\n\n THANKS FOR USING OUT ATM SERVICE");
                        Environment.Exit(0); break;
                        ;*/
                    default:
                        Console.WriteLine("Please, enter a option valid");
                            break;
                    }
            }
            else
                {
                    Console.WriteLine("Please, enter a option valid.");
                }

            do
            {
                Console.WriteLine("Another Transaction? (YES/No)");
                    answerExit = Console.ReadLine();
            } while (answerExit.ToLower() != "no" && answerExit.ToLower() != "yes");
            //------------------------------------------------------//

        } while (answerExit.ToLower() != "no");
        }

        public static Boolean Number(string a)
        {

            try
            {
                int b = Int32.Parse(a);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }

    }
}
