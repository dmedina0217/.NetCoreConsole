using System;
using System.Globalization;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find out your Pay for the Week, Month, Year!!");

            //create variables/constants to house results
            
            //hourly Pay
            Console.WriteLine("Hourly Pay: ");
            var hourlyPayReading=Console.ReadLine();
            float hourlyPay= Convert.ToSingle(hourlyPayReading);
            Console.WriteLine("You Entered: " +  hourlyPay);
            //Weekly Hours
            Console.WriteLine("Weekly Hours: ");
            var WeeklyHoursReading = Console.ReadLine();
            float WeeklyHours= Convert.ToSingle(WeeklyHoursReading);
            Console.WriteLine("You Entered: " + WeeklyHours);

            //Tax Rates
            Console.WriteLine("Taxes for Illinois: Effective January 1, 2015, the rate for withholding Illinois Income Tax is 3.75 percent.");
            Console.WriteLine("Estimated Tax Percentage: ");
            var taxReading= Console.ReadLine();
            float taxes= Convert.ToSingle(taxReading);
            Console.WriteLine(taxes);

            
            float weeklyPay = (hourlyPay * WeeklyHours);
            //Console.WriteLine(weeklyPay);
            
            //tax calculation
            float taxCalculation= (weeklyPay * taxes / 100);
            Console.WriteLine("Total Tax Taken Away: " + taxCalculation.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("     Before Taxes: ");
            Console.WriteLine();
            Console.WriteLine("Weekly Pay Before Taxes: " + weeklyPay.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Monthly Pay Before Tax: " + (weeklyPay * 4).ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine("Yearly Pay Before Tax: " + (weeklyPay * 52).ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine("     After Taxes: ");
            Console.WriteLine();

            float result = weeklyPay - (weeklyPay * taxes / 100);
            Console.WriteLine("Weekly Pay After Taxes: " + result.ToString("C", CultureInfo.CurrentCulture));
            
                        
            // float weeklyPayTaxes = 
            //Console.WriteLine("Weekly Pay After Taxes: " weeklyPay);






            Console.ReadLine();

        }
    }
}
