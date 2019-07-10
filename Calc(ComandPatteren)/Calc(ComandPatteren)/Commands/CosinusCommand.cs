using System;

namespace Calc_ComandPatteren_.Commands
{
    class CosinusCommand : ICommands
    {
        public double Execute(string str)
        {
            try
            {
                double a = double.Parse(str.Remove(str.IndexOf('c')));
                return Math.Round(Math.Cos(a * Math.PI / 180), 6);
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
