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
            int isPresent = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (isPresent == empInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee Absent");
        }
    }
}
