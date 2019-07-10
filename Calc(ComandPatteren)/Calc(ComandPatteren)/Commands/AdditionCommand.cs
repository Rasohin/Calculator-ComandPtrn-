using System;

namespace Calc_ComandPatteren_.Commands
{
    class AdditionCommand : ICommands
    {
        public double Execute(string str)
        {
            try
            {
                double a = double.Parse(str.Remove(str.IndexOf('+')));
                double b = double.Parse(str.Substring(str.IndexOf('+') + 1));
                return a + b;
            }
            catch
            {

                throw new NotImplementedException("Неподдерживаемый набор команд");
            }
            
        }

        public void UnDo()
        {
            
        }
    }
}
