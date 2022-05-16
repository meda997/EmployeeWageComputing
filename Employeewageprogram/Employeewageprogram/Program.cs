using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPresentAbsent
{
    public class EmpWageComputation
    {
        public const float WagesPerHr = 20;
        public const int FullTimeWorkHrsPerDay = 8;
        public const int PartTimeWorkHoursPerDay = 4;
        public const int MaxWorkHrs = 100;
        public const int MaxWorkDays = 20;
        public const int IsFullTime = 2;
        public const int IsPartTime = 1;
        public const int IsAbsent = 0;
        public float TotalWage = 0;
        float EmpDailyWage = 0;

        public void CalculateWage()
        {
            int Day = 1;
            int EmpWorkHrs = 0;
            int TotalWorkHrs = 0;
            while (Day <= MaxWorkDays && TotalWorkHrs <= MaxWorkHrs)
            {
                Random check = new Random();
                int CheckEmp = check.Next(0, 3);
                switch (CheckEmp)
                {
                    case IsAbsent:
                        EmpWorkHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkHrs = 4;
                        break;
                    case IsFullTime:
                        EmpWorkHrs = 8;
                        break;
                }
                EmpDailyWage = EmpWorkHrs * WagesPerHr;

                TotalWage += EmpDailyWage;
                Day++;
                TotalWorkHrs += EmpWorkHrs;
            }
            Console.WriteLine("Total Working Days :" + (Day - 1) + "\nTotal Working Hrs :" + TotalWorkHrs + "\nTotal Employee Wage :" + TotalWage);
        }
        public static void Main(string[] args)
        {
            EmpWageComputation ewc = new EmpWageComputation();
            ewc.CalculateWage();
        }
    }
}
