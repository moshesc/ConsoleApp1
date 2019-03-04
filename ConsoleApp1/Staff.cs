using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Staff
    {
        #region fields
        private string nameOfStaff;
        private const double hourlyRate = 30; //Once crated cannot be change
        private double hWorked;
        #endregion

        #region Properties
        public double HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                {
                    hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }
        #endregion

        #region Methods
        public void PrintMessage()
        {
            Console.WriteLine("Caculate Pay......");
        }

        public  double CalculatePay()
        {
            PrintMessage()
;

            double staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0 )
            {
                return staffPay;
            }
            else
            {
                return 0;
            }
        }
        public double CalculateTax()
        {
            double afterTax;
            double staffPay;
            staffPay = hWorked * hourlyRate;
            afterTax = staffPay * 0.8;
            if (hWorked > 0)
            {
                return afterTax;
            }
            else
            {
                return 0;
            }
        }

        

        public override string ToString()
        {
            return "Name of the staff  = " + nameOfStaff +
                "Month = " + MonthsOfTheYear.February+
                "Hourly rate = " + hourlyRate +
                "Hours worked = " + hWorked;
        }

        #endregion

        #region Constructor
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n "+nameOfStaff);
            Console.WriteLine("-------------------");
        }
        #endregion

        #region Enum
        public enum MonthsOfTheYear{
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        }
        #endregion

    }
}
