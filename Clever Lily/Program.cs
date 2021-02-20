using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double moneySaved = 0;
            int toysReceived = 0;
            double moneyPresent = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {

                    moneySaved += moneyPresent;
                    moneyPresent += 10;
                    moneySaved -= 1;
                }

                else
                {
                    toysReceived += 1;
                }
            }

            double totalMoney = moneySaved + (toysReceived * toyPrice);

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(totalMoney - washingMachinePrice):f2}");
            }

            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - totalMoney):f2}");
            }
        }
    }
}
