using System;

namespace Homework_module_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOp = new ArrayOperator(new int[] { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 }, 10);
            arrayOp.loopArray2();
            arrayOp.Array1 = new int[] { 1, 2, 33, 45, 55, 23, 155, 46, 7, 3};
            Console.WriteLine("Array2 after changing: ");
            arrayOp.loopArray2();
            Console.ReadLine();
        }
    }
}
