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
            Random random = new Random();
            int empInput = random.Next(0, 3);
            switch(empInput)
            {
              case FULL_TIME:
                Console.WriteLine(" Fulltime Employee is Present");
                EMP_HR = 8;
                 break;
              case PART_TIME:
                Console.WriteLine(" Parttime Employee is Present");
                Console.WriteLine("");
                EMP_HR = 4;
                break;
              default:
                Console.WriteLine("Employee aAbsent");
                EMP_HR = 0;
                break;
            }

            EMP_WAGE = EMP_HR * EMPWAGE_WAGE_PER_HR;
            Console.WriteLine("DAILY WAGE OF EMPLOYES:" + EMP_WAGE);
            Console.ReadLine();
        }
    }
}
