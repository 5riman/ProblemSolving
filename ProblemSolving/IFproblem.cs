using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{

    public class IFproblem
    {
        public static void Main(string[] args)
        {
            int EmpId; string Ename; Double DA, HRA, BSalary = 0, TSalary;
            Console.WriteLine("ENter EMPID,ENAME,BSAlary:");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Ename = Console.ReadLine();
            BSalary = Convert.ToDouble(Console.ReadLine());
            if (BSalary >= 30000)
            {
                DA = 0.3 * BSalary;
                Console.WriteLine("So DA is:" + DA);
                HRA = 0.2 * BSalary;
                Console.WriteLine("HRA is:" + HRA);
            }
            else
            {
                DA = 0.2 * BSalary;
                Console.WriteLine("So DA else is:" + DA);
                HRA = 0.1 * BSalary;
                Console.WriteLine("HRA else is:" + HRA);
            }
            TSalary = BSalary-DA + HRA;
            Console.WriteLine("TOTAL SALARY IS :" + TSalary);
            Console.ReadLine();
        }
    }
}
    

