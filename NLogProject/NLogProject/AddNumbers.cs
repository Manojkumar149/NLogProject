using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject
{
    public class AddNumbers
    {
        private readonly NLog nLog = new NLog();
        public int Sum(int firstNumber, int secondNumber)
        {
            if(firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug Successful : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("firstNumber or secondNumber should not equal to zero");
            }
            int result = secondNumber + firstNumber;
            nLog.LogDebug("Debug Successful : Sum()");
            nLog.LogInfo("Sum Method Passed, Result" + result);
            return result;
        }
    }
}
