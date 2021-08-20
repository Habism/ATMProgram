using System;

namespace ATMProgram
{
     class Methods 
    {
        static int isBalance = 1500;

        public static void viewBalance()
        {
            
           Console.WriteLine("Your Balance is " + isBalance);
                
        }

       public static void Deposit()
        {
            int isDeposit;

            Console.WriteLine("Enter the amount to deposit: ");
            isDeposit = Int32.Parse(Console.ReadLine());

            if (isDeposit > 0)
            {
                isBalance = isBalance + isDeposit;
                Console.WriteLine("The amount was entered successfully.");
                Console.WriteLine("Your Balance is " +isBalance);
            }
            else
            {
                Console.WriteLine("Error, please enter a amount valid");
            }
        }

        public static void Withdraw()
        {
     
            int isWithdraw;
            int isOption;

            Console.WriteLine("Select amount to withdraw: ");
            Console.WriteLine("\n1. 200 \n2. 1000  \n3. 2000 \n4. Withdraw specific amount");
          
            isOption = Int32.Parse(Console.ReadLine());

            switch (isOption)
            {
                case 1:
                    if (isBalance > 200)
                    {
                        isBalance = isBalance - 200;
                        Console.WriteLine("Your current Balance is " + isBalance);
                    }
                    else
                    {
                     Console.WriteLine("Isufficient Balance ");
                    }
                    break;
                case 2:
                    if (isBalance > 1000)
                    {
                        isBalance = isBalance - 1000;
                        Console.WriteLine("Your current Balance is " + isBalance);
                    }
                    else
                    {
                        Console.WriteLine("Isufficient Balance ");
                    }
                    break;
                case 3:
                    if (isBalance > 2000)
                    {
                        isBalance = isBalance - 2000;
                        Console.WriteLine("Your current Balance is " + isBalance);
                    }
                    else
                    {
                        Console.WriteLine("Isufficient Balance ");
                    }
                    break;
                case 4:

                    Console.WriteLine("Enter the amount to withdraw: ");
                    isWithdraw = Int32.Parse(Console.ReadLine());

                    if (isWithdraw % 100 != 0)
                    {
                        Console.WriteLine("Please Enter the amount in multiples of 100");
                    }
                    else if (isWithdraw > isBalance)
                    {
                        Console.WriteLine("Isufficient Balance ");
                    }
                    else
                    {
                        isBalance = isBalance - isWithdraw;
                        Console.WriteLine("Your current Balance is " + isBalance);
                    }
                    break;
                    default:
                    Console.WriteLine("Please, enter option valid");
                    break;
            }
   
        }

    }
}
