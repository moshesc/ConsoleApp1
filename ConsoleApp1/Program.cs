using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Program
    {

        static void Main(string[] args)
        {
            double pay;
            double afterTax;
            Staff staff1 = new Staff("Moshe");
            Console.WriteLine("Insert the hours per month: ");
            staff1.HoursWorked = Double.Parse(Console.ReadLine());

            Console.WriteLine("Month: "+Staff.MonthsOfTheYear.February);
            pay = staff1.CalculatePay();
            afterTax = staff1.CalculateTax();
            Console.WriteLine("Net £"+pay);
            Console.WriteLine("After tax dedction: £ "+afterTax);
        }
    }
}
