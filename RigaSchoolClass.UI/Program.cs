using System;

namespace RigaSchoolClass.UI
{
	class Program
	{
		//this is a method
		static void Main(string[] args)
		{

			#region Casting

			string strNumber = "111";

			int resulfOfIntegerType = int.Parse(strNumber) + 1;

			int integerVariable = 1;
			long longVariable = 1222222;
			decimal decimalVariable = 1.3m;
			string stringVariable = "100";

			string result = stringVariable + integerVariable.ToString();
			Console.WriteLine($"Casting result: {result}");

			int intdecimalVariable = (int)decimalVariable;
			int intlongVariable = (int)decimalVariable;
		
			Console.WriteLine($"Decimal casting: {intdecimalVariable}");
			Console.WriteLine($"Long casting: {intlongVariable}");




            #endregion

			#region IntegerSampleRegion

			
			int number1 = 100;
			int number2 = 1;

			int intresult = number1 + number2;

			string number3 = "100";
			string number4 = "1";

			string stringResult = number3 + number4; 

			

			Console.WriteLine($"int result: {intresult}");
			Console.WriteLine($"string result: {stringResult}");

			#endregion

			#region StringSampleRegion

			string helloWorldVariable = "Hello World line 1";
			string helloWorldVariableNumber2 = "Hello World line 2";
			
			//Line 1
			Console.WriteLine("Line 1: " + helloWorldVariable);
			Console.Write(Environment.NewLine);
			
			//Line 2
			Console.WriteLine("Line 2: " + helloWorldVariableNumber2);
			Console.WriteLine(Environment.NewLine);

			//Line 3
			Console.WriteLine("Line 3: " + helloWorldVariable + helloWorldVariableNumber2 + "end of the line");
			Console.Write(Environment.NewLine);

			//Line 4
			Console.WriteLine($"Line 4: {helloWorldVariable} {helloWorldVariableNumber2} end of the line");
			Console.WriteLine(Environment.NewLine);

			//Line 5
			Console.WriteLine(string.Format("Line 5: {0} {1} {2}", helloWorldVariable, helloWorldVariableNumber2, "end of the line"));

			Console.ReadLine();

            //Comment
            //Comment
            //Comment
            //Hellohowareyou
            //newchanges
            //this is a change

            #endregion

        }
    }
}
