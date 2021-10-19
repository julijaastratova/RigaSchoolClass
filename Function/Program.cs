using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Coleections

            #region Operators
            //string strVariable = "Test";
            //int numberVariable = 1;
            //string var1 = "1";
            //var1 = strVariable;
            ////Operator &&
            //bool boolVariableEndOperator = numberVariable == 1 && strVariable == "Test";
            ////Operator ||
            //bool boolVariableOrOperator = numberVariable == 2 || strVariable == "Test negative"
            //    || strVariable == "Test postive";
            ////Operator !
            //bool boolVariableNotOperator = numberVariable != 1;
            ////Relation operators < > != <=
            //bool relationOpVariable1 = 1 > 2;
            //bool relationOpVariable2 = 2 >= 2;
            //bool relationOpVariable4 = 1 <= 2;
            #endregion
            #region Casting
            //string strNumber = "111";
            //int resultOfIntergerType = int.Parse(strNumber) + 1;
            //int integerVariable = 1;
            //long longVariable = 122222;
            //decimal decimalVariable = 1.3m;
            //string stringVariable = "100";
            //string result = stringVariable + integerVariable.ToString();
            //Console.WriteLine(@$"Casting result: {result}");
            //int intdecimalVariable = (int)decimalVariable;
            //int intlongVariable = (int)longVariable; 
            //Console.WriteLine($"Decimal casting: {intdecimalVariable}");
            //Console.WriteLine($"Long casting: {intlongVariable}");
            #endregion
            #region IntegerSampleRegion
            //int number1 = 100;
            //int number2 = 1;
            //int intresult = number1 + number2;
            //string number3 = "100";
            //string number4 = "1";
            //string stringResult = number3 + number4;
            //Console.WriteLine($"int result: {intresult}");
            //Console.WriteLine($"string result: {stringResult}");
            #endregion
            #region StringSampleRegion
            ////string helloWorldVariable = "Hello world line 1. ";
            ////string helloWorldVariableNumber2 = "Hello World line 2";
            //////Line 1
            ////Console.WriteLine("Line 1: " + helloWorldVariable);
            ////Console.Write(Environment.NewLine);
            //////Line 2
            ////Console.WriteLine("Line 2: " + helloWorldVariableNumber2);
            ////Console.Write(Environment.NewLine);
            //////Line 3
            ////Console.WriteLine("Line 3: " + helloWorldVariable + helloWorldVariableNumber2 + " end of the line");
            ////Console.Write(Environment.NewLine);
            //////Line 4
            ////Console.WriteLine($"Line 4: {helloWorldVariable} {helloWorldVariableNumber2} end of the line");
            ////Console.Write(Environment.NewLine);
            //////Line 5
            ////Console.WriteLine( string.Format("Line 5: {0} {1} {2}", helloWorldVariable, helloWorldVariableNumber2, "end of the line"));
            //Console.ReadLine();
            #endregion
            #region MathClassOperators

            //while (new ConsoleKeyInfo().Key != ConsoleKey.A)
            //{
            //    Console.Write("Input number: ");
            //    string inputString = Console.ReadLine();
            //    decimal number = Convert.ToDecimal(inputString);

            //    // value % 2 != 0 Odd number
            //    // value % 2 == 0 Even number
            //    // expresion ? value_1 : value_2
            //    string truOrFalse = (number % 2 != 0) ? $"{number}: is odd number" 
            //        :  $"{number}: is odd even number";
            //    Console.WriteLine(truOrFalse);
            //}
            #endregion
            #region Math basic opertations
            //Random random = new Random();
            //int number_1 = 10;

            //number_1 >= 1 ? true : false
            //Console.Write("enter first integer: ");
            //string number = Console.ReadLine();

            //Console.Write("enter second integer: ");
            //string number1 = Console.ReadLine();
            //int result1 = 0;
            //if (int.TryParse(number, out result1))
            //{
            //    if (int.TryParse(number, out int result2))
            //    {
            //        string equal = (result1 == result2) ? $"{result1} is equal to {result2}" :
            //            (result1 > result2) ? $"{result1} is greater than {result2}" :
            //            $"{result2} is greater than {result1}";
            //        Console.WriteLine(equal);
            //    }
            //    else
            //    {
            //        Console.WriteLine("It is not walid input");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("It is not walid input");
            //}
            //Console.Write("enter the year you wish to check: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //string trueOrFalse = ((a % 100 == 0) && (a % 400 == 0)) ? $"{a} is leap year " :
            //    (a % 4 == 0) ? $"{a} : is leap year " :
            //    $"{a} is not leap year ";
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            #endregion
            #endregion

            //int resultOFSum = GetSum();
            //int resultOfMinus = GetMinus();
            //int resultOfTwoFunctions = resultOFSum / resultOfMinus;
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int resultOFSum = GetSum(number1, number2);
            //int resultOfMinus = GetMinus(number1, number2);
            //Console.WriteLine("Result of two numbers is:" + resultOFSum);
            //Console.WriteLine("Result of two numbers is:" + resultOfMinus);

            //string name = "John";
            //string surname = "Doe";
            //string callBackFromFunction = Contact(name, surname);
            //Console.WriteLine(callBackFromFunction);
            //Console.ReadLine();

            //Console.WriteLine("Please input a name: ");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Welcome friend " + inputString + "!");
            //Console.WriteLine("Have a nice day!");
            //Console.ReadLine();

                Console.WriteLine("Please input a name:");
                string result = Console.ReadLine();
                NameFunction(result);
                Console.ReadLine();

            static void NameFunction(string name)
            {
                Console.WriteLine($@"Welcome fiend {name}!
Have a nice day!");
            }




        }
        static int GetSum()
        {
            var number_1 = 10;
            var number_2 = 11;
            var result = number_1 + number_2;
            return result;
        }
        static int GetMinus()
        {
            var number_1 = 10;
            var number_2 = 11;
            var result = number_1 - number_2;
            return result;
        }
        static int GetSum(int number_1, int number_2)
        {
            return number_1 + number_2;
        }
        static int GetMinus(int number_1, int number_2)
        {
            return number_1 - number_2;
        }
        static string Contact(string name, string surname)
        {
            return $"My name is {name} and my surname is {surname}";
        }
    }
}


















