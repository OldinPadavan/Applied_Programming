using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Four
{
    internal class MyArray
    {
        private double[] _Array;

        public MyArray(double[] _Array)
        {
            this._Array = _Array;
        }

        public int Size()
        {
            return _Array.Length;
        }


        public double ReturnSequenceSum()
        {
            /*Formula of calculation is: Y = x(1) * x(2) * x(3) * x(4) + x(5) * x(6) * x(7) * x(8) + .... + x(n) * (n + 1)  */
            double sum = 0;
            if (_Array.Length % 4 == 0)
            { 

            } else
            {

            }
            return sum;

        }
    }
}
