using Calc_ComandPatteren_.Commands;
using System.Collections.Generic;


namespace Calc_ComandPatteren_
{
    public class Calculator
    {
        public Dictionary<char, ICommands> calc = new Dictionary<char, ICommands>();
        public void  SetCommand(char a, ICommands b)
        {
            calc.Add(a, b);
        }
    }
}
