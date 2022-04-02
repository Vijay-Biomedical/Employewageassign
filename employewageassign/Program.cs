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
            int EMPWAGE_WAGE_PER_HR = 20, EMP_HR = 0, EMP_WAGE = 0;
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int TOTAL_WAGE = 0;
            const int NO_OF_WORKING_DAYS = 20;
            Random random = new Random();
            for (int day = 1; day <= NO_OF_WORKING_DAYS; day++)
             {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                       // Console.WriteLine(" Fulltime Employee is Present");
                        EMP_HR = 8;
                        break;
                    case PART_TIME:
                      //  Console.WriteLine(" Parttime Employee is Present");
                        Console.WriteLine("");
                        EMP_HR = 4;
                        break;
                    default:
                      //  Console.WriteLine("Employee aAbsent");
                        EMP_HR = 0;
                        break;
                }

                EMP_WAGE = EMP_HR * EMPWAGE_WAGE_PER_HR;
                Console.WriteLine(" WAGE FOR DAY{0} EMPLOYES is {1}:", day, EMP_WAGE);
                TOTAL_WAGE += EMP_WAGE;
             }
            Console.WriteLine("TOTAL WAGE FOR {0}DAYS IS:{1}", NO_OF_WORKING_DAYS, TOTAL_WAGE);
            Console.ReadLine();
        }
    }
}
