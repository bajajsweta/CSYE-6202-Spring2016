using System;

namespace GasPump
{
    public class Program
    {
        public enum GasType
        {
            None,
            RegularGas,
            MidgradeGas,
            PremiumGas,
            DieselFuel
        }

        static void Main(string[] args)
        {
            string userInputType = String.Empty;
            string userInputAmount = String.Empty;

            do
            {
                System.Console.Write("Please Enter purchased gas type , Q/q to quit : ");
                userInputType = Console.ReadLine();

                if (UserEnteredSentinelValue(userInputType))
                {
                    Console.WriteLine("Application Terminated");
                    System.Console.WriteLine("Please press any key to continue ...");
                    Console.ReadLine();
                    return;
                }
                else {
                    UserEnteredValidGasType(userInputType);
                    System.Console.Write("Please Enter purchased gas amount , Q/q to quit : ");
                    userInputAmount = Console.ReadLine();
                    if (UserEnteredSentinelValue(userInputAmount))
                    {
                        Console.WriteLine("Application Terminated");
                        System.Console.WriteLine("Please press any key to continue ...");
                        Console.ReadLine();
                        return;
                    }
                    else {
                        UserEnteredValidAmount(userInputAmount);
                        GasType gastype = GasTypeMapper(Convert.ToChar(userInputType));
                        System.Console.WriteLine("You have brought " + userInputAmount + " gallons of "
                        + gastype + "at $ " + GasPriceMapper(gastype));
                        double totalCost = 0.0;
                        CalculateTotalCost(gastype, Convert.ToDouble(userInputAmount), ref totalCost);
                        System.Console.WriteLine("Your Total purchase costs is : $ " + Convert.ToString(totalCost));
                    }

                }
            }
            while (userInputType != "q" || userInputType != "Q" || userInputAmount != "q" || userInputAmount != "Q");
        }

        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
        {
            // your implementation here

            var result = false;
            if (userInput == null)
            { result = false; }
            else if (userInput.Equals("q") || userInput.Equals("Q"))
            {
                result = true;
                //System.Console.WriteLine("Application Terminated");
                //System.Console.WriteLine("Please press any key to continue ...");
                // System.Console.ReadKey();
                // Environment.Exit(0);
            }
            return result;

        }



        // use this method to parse and check the characters entered
        // this does not conform 
        public static bool UserEnteredValidGasType(string userInput)
        {
            var result = false;

            if (userInput != null)
            {
                // your implementation here

                if (userInput.Equals("r") || userInput.Equals("R"))
                { result = true; }
                else if (userInput.Equals("m") || userInput.Equals("M"))
                { result = true; }
                else if (userInput.Equals("p") || userInput.Equals("P"))
                { result = true; }
                else if (userInput.Equals("d") || userInput.Equals("D"))
                { result = true; }
                else if (userInput.Equals(" "))
                { result = false; }

            }
            return result;
        }

        // use this method to parse and check the double type entered
        // please use Double.TryParse() method 
        public static bool UserEnteredValidAmount(string userInput)
        {
            var result = false;

            // your implementation here
            if (userInput != null)
            {
                try
                {
                    Convert.ToDouble(userInput);
                    result = true;
                }
                catch

                {
                    result = false;

                }
            }
            return result;
        }

        // use this method to map a valid char entry to its enum representation
        // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
        // this mapping "must" be used within CalculateTotalCost() method later on
        public static GasType GasTypeMapper(char c)
        {
            GasType gasType = GasType.None;
            // GasType gasName = 

            // your implementation here
            if (c == 'r' || c == 'R')
            { gasType = (GasType.RegularGas); }
            else if (c == 'm' || c == 'M')
            { gasType = (GasType.MidgradeGas); }
            else if (c == 'p' || c == 'P')
            { gasType = (GasType.PremiumGas); }
            else if (c == 'd' || c == 'D')
            { gasType = (GasType.DieselFuel); }

            return gasType;
        }

        public static double GasPriceMapper(GasType gasType)
        {
            var result = 0.0;

            // your implementation here
            if (gasType == GasType.RegularGas)
            { result = (1.94); }
            else if (gasType == GasType.MidgradeGas)
            { result = (2.00); }
            else if (gasType == GasType.PremiumGas)
            { result = (2.24); }
            else if (gasType == GasType.DieselFuel)
            { result = (2.17); }

            return result;
        }

        public static void CalculateTotalCost(GasType gasType, double gasAmount, ref double totalCost)
        {
            // your implementation here

            if ((gasType == GasType.RegularGas) && (gasAmount > 0))
            { totalCost = gasAmount * 1.94; }
            else if ((gasType == GasType.MidgradeGas) && (gasAmount > 0))
            { totalCost = gasAmount * 2.00; }
            else if ((gasType == GasType.PremiumGas) && (gasAmount > 0))
            { totalCost = gasAmount * 2.24; }
            else if ((gasType == GasType.DieselFuel) && (gasAmount > 0))
            { totalCost = gasAmount * 2.17; }
            else { totalCost = 0; }
        }
    }

}
