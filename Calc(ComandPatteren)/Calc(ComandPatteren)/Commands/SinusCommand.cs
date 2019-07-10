using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_ComandPatteren_.Commands
{
    class SinusCommand : ICommands
    {
        public double Execute(string str)
        {
            try
            {
                double a = double.Parse(str.Remove(str.IndexOf('s')));
                return Math.Round(Math.Sin(a * Math.PI / 180), 6);
            }
            catch
            {
                throw new NotImplementedException("Не поддерживаемый набор команд");
            }
            
        }

        public void UnDo()
        {
            
        }
    }
}
