using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace employewageassign
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1, EMPWAGE_WAGE_PER_HR = 20, EMP_HR = 0, EMP_WAGE = 0;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (isPresent == empInput)
            {
                Console.WriteLine("Employee is Present");
                EMP_HR = 8;
            }
            else
            {
                Console.WriteLine("Employee Absent");
                EMP_HR = 0;
            }

            EMP_WAGE = EMP_HR * EMPWAGE_WAGE_PER_HR;
            Console.WriteLine("DAILY WAGE OF EMPLOYE:" + EMP_WAGE);
            Console.ReadLine();
        }
    }
}
