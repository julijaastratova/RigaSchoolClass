using System;

namespace HomeWorkDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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
