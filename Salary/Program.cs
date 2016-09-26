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

            
            float weeklyPay = (hourlyPay * WeeklyHours);
            //Console.WriteLine(weeklyPay);
            
            //tax calculation
            //float taxCalculation= (weeklyPay * taxes / 100);
            //Console.WriteLine("Total Tax Taken Away: " + taxCalculation.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("     Before Taxes: ");
            Console.WriteLine();
            Console.WriteLine("Weekly Pay Before Taxes: " + weeklyPay.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Monthly Pay Before Tax: " + (weeklyPay * 4).ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine("Yearly Pay Before Tax: " + (weeklyPay * 52).ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine("     After Taxes: ");
            Console.WriteLine();

            //float result = weeklyPay - (weeklyPay * taxes / 100);
            //Console.WriteLine("Weekly Pay After Taxes: " + result.ToString("C", CultureInfo.CurrentCulture));
            
                        
            // float weeklyPayTaxes = 
            //Console.WriteLine("Weekly Pay After Taxes: " weeklyPay);

            //mandatory taxes
            Console.WriteLine();
            //Console.WriteLine("*"*30);
            Console.WriteLine("Mandatory Taxes: " );
            double fica= 5.77218270310745 * weeklyPay /100;
            Console.WriteLine("FICA: " + fica.ToString("C", CultureInfo.CurrentCulture));
            double ficaMedicare=1.350617746162486 * weeklyPay / 100;
            Console.WriteLine("FICA Medicare: " + ficaMedicare.ToString("C", CultureInfo.CurrentCulture));
            double ficaTax= 8.593223511793336 * weeklyPay / 100;
            Console.WriteLine("FICA Tax: " + ficaTax.ToString("C", CultureInfo.CurrentCulture));
            double stateTax=3.269374766005241 * weeklyPay / 100;
            Console.WriteLine("State Tax: " + stateTax.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine();

            double totalDeductions = fica + ficaMedicare + ficaTax + stateTax;
            
            Console.WriteLine("Total Deducations: " + totalDeductions.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine("*"*);
            Console.WriteLine();

            double weeklyPayAfterDeductions=weeklyPay - totalDeductions;
            double monthlyPayAfterDeductions= weeklyPayAfterDeductions * 4;
            double yearlyPayAfterDeductions= weeklyPayAfterDeductions * 52;
            Console.WriteLine("Weekly Pay After Deductions: " + weeklyPayAfterDeductions.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Monthly Pay After Deductions: " + monthlyPayAfterDeductions.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Yearly Pay After Deductions: " + yearlyPayAfterDeductions.ToString("C", CultureInfo.CurrentCulture));









            Console.ReadLine();

        }
    }
}
