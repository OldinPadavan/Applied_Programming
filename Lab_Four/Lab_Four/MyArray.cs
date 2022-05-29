using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Four
{
    public class MyArray
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
            double multiPart = 1;
            for (int i = 0; i < _Array.Length; i++)
            {
                if (i % 3 == 0)
                {
                    sum += multiPart;
                    multiPart = 1;
                }
                multiPart *= _Array[i];
                
            }
            if (multiPart > 1 & multiPart != 1)
            {
                sum += multiPart;
            }
            return sum;
            

        }
    }
}
