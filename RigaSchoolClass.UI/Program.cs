using System;
using System.Linq;

namespace RigaSchoolClass.UI
{
	class Program
	{
        //this is a method
        static void Main(string[] args)
		{

            #region Array

            object[] objectArr = { 1, "string", 2.3, '\u006A' };
            foreach (var objectItem in objectArr)
            {
                if (objectItem is int item)
                {
                    Console.Write($"Integer value is: {item}");
                }
                if (objectItem is string item1)
                {
                    Console.Write($"String value is: {item1}");
                }
            }

            //Option 2
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "name", "surname" };
            double[] doubleArr = { 2.3, 22, 3.4 };
            #endregion
            #region Loops
            #region for loop
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine($"For loop iteration number: {i}");
                //break;
                //continue;
            }

            int[] integerArray = { 1, 2, 3, 4, 5 };
            int val = integerArray[2];
            for (int i = 0; integerArray.Length > i; i++)
            {
                Console.WriteLine($"For loop iteration number: {integerArray[i]}");
                //break;
                //continue;
            }
            for (int i = 0; stringArray.Length > i; i++)
            {
                Console.WriteLine($"For loop iteration number: {integerArray[i]}");
                //break;
                //continue;
            }
            #endregion
            #region while loop
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number++);
            }
            #endregion
            #region foreach
            double[] doubleArray = new double[] { 2, 3, 4, 5 };
            var lenght = doubleArray.Length;
            foreach (var doubleItem in doubleArray)
            {
                Console.WriteLine($"Foreach iteration number: {doubleItem}");
            }
            #endregion

            #endregion

            #region classwork1array

            //Option 1
            //int[] intArray;
            //intArray = new int[6];

            //intArray[0] = 0;
            //intArray[1] = 1;
            //intArray[2] = 2;
            //intArray[3] = 3;
            //intArray[4] = 4;
            //intArray[5] = 5;

            //Option 2
            //int[] testArray = { 1, 2, 3, 4, 5 };
            //string[] stringArray = { "name", "surname"};
            //double[] doubleArr = { 2.3, 22, 3.4 };

            //string[] stringArray1 = { "first element", "second element" };
            //Console.WriteLine($"Here is the: {stringArray1[1]}");
            //Console.ReadLine();

            //string[] myName = {"j", "u", "l", "i", "j", "a"};
            //Console.WriteLine(myName[1]);

            //string[] stringArray2 = { "one", "two" };
            //for (int i = 0; i < stringArray2.Length; i++)
            //{
            //    if (i==1)
            //    {
            //        Console.WriteLine(stringArray2[i]);
            //    }
            //}
            //Console.ReadLine();



            #endregion

            #region foreachclasswork
            //iterating each number

            //int[] integerArray = new int[10];
            //integerArray[0] = 1;

            //double[] doubleArray = new double[] { 2, 3, 4, 5 };
            //var length = doubleArray.Length;

            //foreach (var doubleItem in doubleArray)
            //{
            //    Console.WriteLine($"Foreach iteration number {doubleItem}");
            //}

            #endregion

            #region for loopclasswork

            //for (int i = 0; i<5; i++)
            //{
            //    Console.WriteLine($"For loop iteration number: {i}");
            //}

            //int[] integerArray1 = {1, 2, 3, 4, 5};

            //for (int i = 0; integerArray1.Length > i; i++)
            //{
            //    Console.WriteLine($"For loop iteration number: {integerArray1[i]}");
            //}


            #endregion

            #region while loopclasswork

            //int number = 0;
            //while (number <5)
            //{
            //    Console.WriteLine(number++);
            //}

            #endregion

            #region loopsclasswork

            //bool finish = false;
            //int numb = 0;

            //while (!finish)
            //{
            //    Console.WriteLine($"Iteration number: {numb++}");
            //    if (finish == false)
            //    {
            //        finish = true;
            //    }
            //}


            ////this works infinitely
            //int numb = 0;
            //while (true)
            //{
            //    Console.WriteLine($"Iteration number: {numb++}");
            //}


            //string exitOption = "Continue";

            //while (exitOption == "Continue")

            #endregion

            #region Press Key A


            //Console.Write("Press any key on the keyboard");

            //if (Console.ReadKey().Key == ConsoleKey.A)
            //{
            //	Console.WriteLine();
            //	Console.WriteLine($"You pressed key: A");
            //}
            //else
            //{
            //	Console.WriteLine("It is not A");
            //}



            ////Console.WriteLine($"You pressed any key: {Console.ReadKey().Key}");

            //Console.ReadLine();


            #endregion

            #region cards

            //If you don’t have the cards, buy them
            //Take the card pack in your hands
            //Open the card pack
            //Take the cards out of the pack
            //Mix the cards
            //Take 6 random cards
            //Place them in your left hand with the help of the right hand
            //Organize the cards from smaller value to the bigger value, left to right
            //Hold the deck of cards loosely between your left thumb and fingers

            #endregion


            #region classwork

            //			Console.Write("enter first integer: ");
            //			string number70 = Console.ReadLine();

            //			Console.Write("enter second integer: ");
            //			string number71 = Console.ReadLine();
            //			int result80 = 0;
            //​
            //            if (int.TryParse(number71, out result80))
            //			{
            //				if (int.TryParse(number71, out int result81))
            //				{
            //					string equal = (result80 == result81) ? $"{result80} is equal to {result81}" :
            //						(result80 > result81) ? $"{result80} is greater than {result81}" :
            //						$"{result81} is greater than {result80}";
            //​
            //                    Console.WriteLine(equal);
            //				}
            //				else
            //				{
            //					Console.WriteLine("It is not valid input");
            //				}
            //			}
            //			else
            //			{
            //				Console.WriteLine("It is not a valid input");
            //			}
            //​
            //            Console.ReadLine();

            Console.Write("Input number 1: ");
            string inputString8 = Console.ReadLine();
            if (int.TryParse(inputString8, out int result))
            {
                Console.Write("Input number 2: ");
                string inputString12 = Console.ReadLine();
                int intInputString4 = int.Parse(inputString12);
                if (result == intInputString4)
                {
                    Console.WriteLine($"{result} and {intInputString4} are equal");
                }
                else
                {
                    Console.WriteLine($"{result} and {intInputString4} are unequal");
                }

            }

            else
            {
                Console.WriteLine("Input is invalid");
            }

            Console.ReadLine();


            //Console.Write("Input number 1: ");
            //string inputString3 = Console.ReadLine();
            //int number10 = Convert.ToInt16(inputString3);

            //Console.Write("Input number 2: ");
            //string inputString4 = Console.ReadLine();
            //int number11 = Convert.ToInt16(inputString4);

            //string result1 = (number10 == number11) ? $"{ number10 } is equal to { number11 }" : $"{ number10 } is not equal to { number11 }";


            //Console.WriteLine(result1);

            //Console.ReadLine();

            Console.Write("Please input a year: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string trOrFalse = ((a % 100 == 0) && (a % 4 == 0)) ? $"{a} is a leap year " :
                (a % 4 == 0) ? $"{a} : is a leap year " :
                $"{a} is not a leap year";
            Console.WriteLine(trOrFalse);
            Console.ReadLine();


   //         Console.WriteLine("Input a year: ");
			//string year = Console.ReadLine();
			//int intYear = int.Parse(year);

			//string trueOrFalse = intYear % 4 == 0 ? $"{intYear}: Leap year" : $"{intYear}: Not a leap year";

			//Console.WriteLine(trueOrFalse);
			//Console.ReadLine();




			#endregion

			#region Math basic operations

			//int a = int.MaxValue;
			//double b = double.MaxValue;

			//int a = 100;

			//Console.WriteLine(a++); //100
			//Console.WriteLine(a++); //101
			//Console.WriteLine(a++); //102
			//Console.WriteLine(a++); //103
			//Console.WriteLine(a++); //104
			//Console.WriteLine(a++); //105

			//int b = 100;

			//Console.WriteLine(b--); //100
			//Console.WriteLine(b--); //99
			//Console.WriteLine(b--); //98
			//Console.WriteLine(b--); //97
			//Console.WriteLine(b--); //96
			//Console.WriteLine(b--); //95

			//int a = 100;

			//int[] massive =  { 1, 10, 3, 89, 77, 66};

			//for(int i = 0; i<massive.Length; i++)
   //         {
			//	Console.WriteLine(massive[i]);
			//}

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine(i);

				////if (i <= 3)
				////	break;

    //        };


            //Console.WriteLine(Math.PI);

            //Random random = new Random();
            //Console.WriteLine(random.Next(0, 10));

            //Console.WriteLine(Math.Round(5.6));

            //Console.WriteLine(Math.Sqrt(64));

            //int number_1 = 10;
            //number_1 *= 10;
            //number_1 /= 10;

            //Console.WriteLine(number_1);

            //Console.WriteLine(number_1 > 1 ? true : false);
            //Console.WriteLine(number_1 >= 1 ? true : false);

            //if (number_1 >= 1)
            //{
            //	Console.WriteLine(true);
            //}
            //else
            //{
            //	Console.WriteLine(false);
            //}
			 
			//if true show 1, if false show 2
   //         int number_2 = number_1 == 1 ? 1 : 2;

   //         if (number_1 == 1)
   //         {
			//	number_2 = 1;
   //         }
   //         else
   //         {
			//	number_2 = 2;
   //         }

			//Console.WriteLine(number_2);
			Console.ReadLine();

			#endregion

			#region MatchClassOperators

			//Console.WriteLine("Input number: ");

			//string number = Console.ReadLine();
			//int evenNumber = 0;
			//int oddNumber = 0;
			//// value % 2 != 0
			//// value % 2 == 0

			//Console.WriteLine($"Even number is: {evenNumber}");
			//Console.WriteLine($"Odd number is {oddNumber}");
			//Console.ReadLine();

			//while (new ConsoleKeyInfo().Key != ConsoleKey.A)
   //         {
			//	Console.Write("Input number: ");
			//	string inputString = Console.ReadLine();
			//	//int integerVariable1 = int.Parse(inputString);
			//	decimal number = Convert.ToDecimal(inputString);
   //             //integerVariable1 = (int)number;
   //             // value % 2 != 0 Odd number
   //             // value % 2 == 0 Even number
   //             // expression ? value_1 : value_2

   //             //question ? //       //TRUE//                   //FALSE//   
   //             //string truOrFalse = (10 > 1) ? "It is greater than 1" : "It is not greater than one";
   //             //bool trFalse = (number > 1) ? true : false;

   //             string truOrFalse = (number > 1) ? $"{number}: is odd number"
   //                 : $"{number} is odd even number";
			//	//string truOrFalse = (number % 2 ! = 0) ? $"{number}: is odd number"
			//	//   : $"{number} is odd even number";

			//	//string truOrFalse = number % 2 != 0 ? "Odd" : "Even";

			//	Console.WriteLine(truOrFalse); 
   //         }

			#endregion

			#region Operators

			//string strVariable = "Test";
			//int numberVariable = 1;

			//string var1 = "1";
			//var1 = strVariable;

			////Operator &&
			//bool boolVariableEndOperator = numberVariable == 1 && strVariable = "Test"; //true + true = true ; false + false = true; true + false = false

			////Operator ||
			//bool boolVariableOrOperator = numberVariable == 12 || strVariable = "Test negative" || strVariable = "Test";   //false + false + true = true

			////Operator !
			//bool boolVariableNotOperator = numberVariable != 1;     //false

			////Relation Operators < > != <=
			//bool relationOpVariable1 = 1 > 2;     //false
			//bool relationOpVariable2 = 2 >= 2;    //true
			//bool relationOpVariable3 = 1 <= 2;    //true
			
			#endregion

			#region Casting

			string strNumber = "111";

			int resulfOfIntegerType = int.Parse(strNumber) + 1;

			int integerVariable = 1;
			long longVariable = 1222222;
			decimal decimalVariable = 1.3m;
			string stringVariable = "100";

			string result90 = stringVariable + integerVariable.ToString();
			Console.WriteLine($"Casting result: {result90}");

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


            Console.ReadLine();
        }

        #region Functions
        static void IterateLoop()
        {                //0, 1
            int[,] array = {{11, 23, 44}, {34, 422, 332}}; //i<2 means two elements, j<3 means 3 elements
            //string[,] strArray = {{"name", "surname"}, {"age", "weight"}}; //i<2 ; j<2

​
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)

                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }



        //static void IterateLoop()
        //{
        //    int[] array = { 1, 2, 3, 4, 5 };

        //    foreach (var itemInArray in array)
        //    {
        //        Console.WriteLine(itemInArray);
        //    }
        //}

        //static void OutOfRange()
        //{
        //    int[] arr = {1, 2, 3};

        //    for(int i = 0; i > arr.Length; i++)
        //    {
        //        Console.WriteLine($"Array item value: {arr[i]}");
        //    }
        //}



        static void OutOfRange()
        {
            int[] arr = { 1, 2, 3 };

            //int[] arr1 = new int[10];*/ //empty array, [10] is the length of the array
            int variable = 1;

            for (int i = 0; i < 3; i++)
            {
                //arr = {1, 2, 3}
                arr[i] = i++;
            }

            for (int i = 0; i < 5; i++) ;

            //int[] arr = { 1, 2, 3 };

            //for (int i = 0; i < 5; i++)
            //    if (arr.Length >= i)
            //{
            //    Console.WriteLine($"Array item value: {arr[i]}");
            //}
            //    else
            //    {
            //        break;
            //    }
        }
        #endregion

        static void FillArray()
        {
            int[] intArr = new int[10];
            //string[] stringArr = new string[10];
            for (int i = 0; i < 10; i++)
            {
                intArr[i] = i;
                //stringArr[i] = $"Item number: {i}";
            }
        }

        static void FindMaxNumber()
        {
            //static void Main(string[] args)
            //{
            //    int[] array = { 1, 2, 3, 10000 };
            //    {
            //        Console.WriteLine(array.Max());
            //    }
            //    Console.ReadKey();

            {
                int[] intArray = { 123123213, 231223, 2222, 34334 };
                var biggestVal = intArray.Max();
                var smallestVal = intArray.Min();
            }


        }

        static void ReverseArra()
        {
            //int[] arr = { 1, 2, 3, 4 }; //4, 3, 2, 1

            //arr.Reverse();

        }

        static void FindElementInsideOfArray()
        {
            string[] stringArray = { "fox_1", "cat", "dog_1" };

            foreach (var strVal in stringArray)
            {
                //strVal.EndsWith("_1");
                //if(strVal.EndsWith("_1"))
                if (strVal.StartsWith("f"))
                {
                    Console.Write(strVal);
                }
            }

            Console.ReadLine();
        }

    }
    }

