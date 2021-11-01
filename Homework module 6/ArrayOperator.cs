using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_module_6
{
    class ArrayOperator
    {
        public int[] array1;
        public int[] array2;

        public ArrayOperator(int[] array1, int arrSize2)
        {
            this.array1 = array1;
            this.array2 = new int[arrSize2];
        }

        public int[] Array1
        {
            get { return array1; }
            set { array1 = value; }
        }

        public int[] Array2
        {
            get { return array2; }
            set { array2 = value; }
        }

        public void loopArray2()
        {
            Array.Copy(array1, array2, array2.Length);

            foreach (int value in array2)
            {
                Console.WriteLine(value);
            }
        }
    }
}

