using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace HomeWorkDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework module 5
            //CheckPhoneNumber("+35 392-022-194") → true 
            //CheckPhoneNumber("+958 28492-503") → false
            string exitOption = "Continue";
            while (exitOption == "Continue")
            {           
                Console.Write("Please enter the number: ");

                string inputNumber = Console.ReadLine();

                string pattern = @"^[+]\d+\s\d+[-]\d+[-]\d+";

                var rgx = new Regex(pattern);

                Match output = Regex.Match(inputNumber, pattern);

                if (rgx.IsMatch(inputNumber))
                {
                    Console.WriteLine($"True");
                }
                else
                {
                    Console.WriteLine($"False");
                }
            }

            Console.ReadLine();
            #endregion

            #region Homwork module 4.4

            int[] Array1 = {12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1};
            int[] Array2 = new int[10];

            Array.Copy(Array1, Array2, 10);

            foreach (int value in Array2)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();

            #endregion

            #region Homework module 4.3
            int[] arr = {12345, 6789, 101112, 1314, 15};
            int sum0 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum0 += arr[i];
            }

            Console.WriteLine(sum0);
            Console.ReadLine();
            #endregion

            #region Homerwork module 4.3.1
            //int[] array = { 2, 4, 6, 8, 10 };

            //int sum1 = 0;
            //foreach (int item in array)
            //{
            //    sum1 += item;
            //}

            //Console.WriteLine(sum1);
            #endregion

            #region Homework module 4.3.2

            //int[] nrArray = { 3, 5, 7, 9, 11 };

            //int sum = 0;
            //Array.ForEach(nrArray, i => sum += i);

            //Console.WriteLine(sum);

            #endregion

            #region Homework module 4.2 edited

            Start0:
            Console.WriteLine("Calculate circle area - press 1, calculate square area - press 2");
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int madeChoice))
            {
                if (madeChoice == 1 || madeChoice == 2)
                {
                    runChoice(madeChoice);
                }

                else
                {
                    Console.WriteLine("Please enter 1 or 2");
                    goto Start0;
                }
            }

            else
            {
                Console.WriteLine("Please enter 1 or 2");
                goto Start0;
            }

            Console.ReadLine();





            static void getCircleArea(double rad)
            {
                rad += rad;
                rad *= Math.PI;
                Console.WriteLine("Your circle area is: " + rad);
            }

            static void getSquareArea(double sL)
            {
                sL *= sL;
                Console.WriteLine("Your square area is: " + sL);
            }


            static void getcircleAreaResult()
            {
                Start1:
                Console.WriteLine("Please input radius:");
                string radius1 = Console.ReadLine();
                if (double.TryParse(radius1, out double enteredRadius))
                {
                    getCircleArea(enteredRadius);
                }

                else
                {
                    Console.WriteLine("Please enter radius using numbers");
                    goto Start1;
                }
            }


            static void getSquareAreaResult()
            {
                Start2:
                Console.WriteLine("Please input side length:");
                string sideLength1 = Console.ReadLine();
                if (double.TryParse(sideLength1, out double enteredSideLength))
                {
                    getSquareArea(enteredSideLength);
                }

                else
                {
                    Console.WriteLine("Please enter side length using numbers");
                    goto Start2;
                }            
            }



            static void runChoice(int choice)
            {
                switch (choice)
                {
                    case 1:
                        getcircleAreaResult();
                        break;
                    case 2:
                        getSquareAreaResult();
                        break;
                }
            }


            #endregion

            #region Homework Module 4.2

        //    Start0:
        //    Console.WriteLine("Calculate circle area - press 1, calculate square area - press 2");
        //    string choice = Console.ReadLine();
        //    if(int.TryParse(choice, out int madeChoice))
        //    {
        //        if (madeChoice == 1 || madeChoice == 2)
        //        {
        //            switch (madeChoice)
        //            {
        //                case 1:
        //                    Start1:
        //                    Console.WriteLine("Please input radius:");
        //                    string radius = Console.ReadLine();
        //                    if (double.TryParse(radius, out double enteredRadius))
        //                    {
        //                        getCircleArea(enteredRadius);
        //                    }

        //                    else
        //                    {
        //                        Console.WriteLine("Please enter radius using numbers");
        //                        goto Start1;
        //                    }

        //                    break;
        //                case 2:
        //                    Start2:
        //                    Console.WriteLine("Please input side length:");
        //                    string sideLength = Console.ReadLine();
        //                    if (double.TryParse(sideLength, out double enteredSideLength))
        //                    {
        //                        getSquareArea(enteredSideLength);
        //                    }

        //                    else
        //                    {
        //                        Console.WriteLine("Please enter side length using numbers");
        //                        goto Start2;
        //                    }

        //                    break;
        //            }
        //        }

        //        else
        //        {
        //            Console.WriteLine("Please enter 1 or 2");
        //            goto Start0;
        //        }
        //    }

        //    else
        //    {
        //        Console.WriteLine("Please enter 1 or 2");
        //        goto Start0;
        //    }

        //    Console.ReadLine();



        //    static void getCircleArea(double rad)
        //    {
        //        rad += rad;
        //        rad *= Math.PI;
        //        Console.WriteLine("Your circle area is: " + rad);
        //    }

        //    static void getSquareArea(double sL)
        //    {
        //        sL *= sL;
        //        Console.WriteLine("Your square area is: " + sL);
        //    }


            #endregion

            #region Homework Module 4: Months

            Start:

            Console.Write("Please enter the month number: ");
            string inputString = Console.ReadLine();

            if (int.TryParse(inputString, out int month))   
            {
                if (month <= 12 && month > 0)
                {
                    int days = 0;
                    string monthName = "";

                    switch(month)
                    {
                        case 1:
                            days = 31;
                            monthName = "January";
                            break;
                        case 2:
                            days = 28;
                            monthName = "February";
                            break;
                        case 3:
                            days = 31;
                            monthName = "March";
                            break;
                        case 4:
                            days = 30;
                            monthName = "April";
                            break;
                        case 5:
                            days = 31;
                            monthName = "May";
                            break;
                        case 6:
                            days = 30;
                            monthName = "June";
                            break;
                        case 7:
                            days = 31;
                            monthName = "July";
                            break;
                        case 8:
                            days = 31;
                            monthName = "August";
                            break;
                        case 9:
                            days = 30;
                            monthName = "September";
                            break;
                        case 10:
                            days = 31;
                            monthName = "October";
                            break;
                        case 11:
                            days = 30;
                            monthName = "November";
                            break;
                        case 12:
                            days = 31;
                            monthName = "December";
                            break;
                        default:
                            Console.WriteLine("Error! There are only 12 months");
                            break;

                    }

                    Console.WriteLine("Your entered month is : " + monthName + ". It consists of " + days + " days.");
                }

                else
                {
                    Console.WriteLine("Error! There are only 12 months");
                    goto Start;
                }
            }

            else
            {
                Console.WriteLine("Error! There are only 12 months and please use only numbers.");
                goto Start;
            }

            Console.ReadLine();




            #endregion

            #region Homework Module 3: absolute value number

            Console.Write("Input decimal number: ");
            string inputString1 = Console.ReadLine();

            Console.Write("Input double number: ");
            string inputString2 = Console.ReadLine();

            Console.Write("Input int16 number: ");
            string inputString3 = Console.ReadLine();

            Console.Write("Input int32 number: ");
            string inputString4 = Console.ReadLine();

            Console.Write("Input int64 number: ");
            string inputString5 = Console.ReadLine();


            if (int.TryParse(inputString1, out int result1) &&
                int.TryParse(inputString2, out int result2) &&
                int.TryParse(inputString3, out int result3) &&
                int.TryParse(inputString4, out int result4) &&
                int.TryParse(inputString5, out int result5))
            {
                decimal dec = Convert.ToDecimal(inputString1);
                dec = Math.Abs(dec);
                double doub = Convert.ToDouble(inputString2);
                doub = Math.Abs(doub);
                short sh = Convert.ToInt16(inputString3);
                sh = Math.Abs(sh);
                int integ = Convert.ToInt32(inputString4);
                integ = Math.Abs(integ);
                long longg = Convert.ToInt64(inputString5);
                longg = Math.Abs(longg);

                Console.WriteLine("Your absoulte decimal number is: " + dec);
                Console.WriteLine("Your absoulte double number is: " + doub);
                Console.WriteLine("Your absoulte int16 number is: " + sh);
                Console.WriteLine("Your absoulte int32 number is: " + integ);
                Console.WriteLine("Your absoulte int64 number is: " + longg);
            }

            else
            {
                Console.WriteLine("One our more inputs were invalid");
            }
                
                Console.ReadLine();
      






            #endregion

            #region about me variable homework

            decimal height = 1.65m;
            decimal agePoint = 30.10m;
            int age = 30;
            DateTime date = DateTime.Now;
            string name = "Julija";
            string city = "Riga";
          
            Console.WriteLine("My name is " + name + ", my height is " + height + " cm.");
            Console.WriteLine("I am " + agePoint + " years old, but in fact I am still " + (int)agePoint + ".");
            Console.WriteLine("I am from " + city + ".");
            Console.WriteLine("Today is " + date + ", thank you for your attention!");
            Console.ReadLine();

            #endregion
        }
    }
}
