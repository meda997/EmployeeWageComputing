using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentAbsent
{
    public class Program
    {
        public int EmpPresent = 1;
        public int EmpHr = 8;
        public int WagesPerHr = 20;
        public void CheckEmpPresentAbsent()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
                int DailyWagePerHr = EmpHr * WagesPerHr;
                Console.WriteLine("Dailywages :" + DailyWagePerHr);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[] args)
        {
            Program pg = new Program();
            pg.CheckEmpPresentAbsent();
        }
    }
}