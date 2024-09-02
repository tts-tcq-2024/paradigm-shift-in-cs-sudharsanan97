using System;
 
namespace paradigm_shift_csharp
{
    class Checker
    {
        static bool batteryIsOk(float temp, float soc, float CRate)
        {
            return istempOk(temp) && isSocOk(soc) && isCRateOk(cRate);
        }
 
        static bool istempOk(float temp)
        {
            if (temp < 0 || temp > 45)
            {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }
            return true;
        }
 
        static bool isSocOk(float soc)
        {
            if (soc < 20 || soc > 80)
            {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            return true;
        }
 
        static bool isCRateOk(float cRate)
        {
            if (cRate > 0.8)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }
 
        static void ExpectTrue(bool exp)
        {
            if (!exp)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }
 
        static void ExpectFalse(bool exp)
        {
            if (exp)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
 
        static int Main()
        {
            ExpectTrue(batteryIsOk(25, 70, 0.7f));  // All values within the range
            ExpectFalse(batteryIsOk(50, 85, 0.0f));  // All values out of the range
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
