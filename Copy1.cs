using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_try
{
    internal class Copy1
    {




//        using System;
//using System.Collections.Generic;

//namespace Delegate_try
//    {
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                List<Employee> employees = new List<Employee>();
//                employees.Add(new Employee() { ID = 1, Name = "Mary", Salary = 5000, Experience = 5 });
//                employees.Add(new Employee() { ID = 2, Name = "Nura", Salary = 12000, Experience = 12 });
//                employees.Add(new Employee() { ID = 3, Name = "Maher", Salary = 3000, Experience = 3 });
//                employees.Add(new Employee() { ID = 4, Name = "Hozaifa", Salary = 9000, Experience = 9 });

//                DelegateIfPromotable IsPromotableEx5 = new DelegateIfPromotable(IfPromotableExperience5);
//                DelegateIfPromotable IsPromotableEx9 = new DelegateIfPromotable(IfPromotableExperience9);
//                DelegateIfPromotable IsPromotableSalary = new DelegateIfPromotable(IfPromotableSalary);

//                Console.WriteLine("Promotion for Experience > = 5 years");
//                Employee.PromoteEmployee(employees, IsPromotableEx5);

//                Console.WriteLine("\nPromotion for Experience > = 9 years");
//                Employee.PromoteEmployee(employees, IsPromotableEx9);

//                Console.WriteLine("\nPromotion for Salary > = 10,000$");
//                Employee.PromoteEmployee(employees, IsPromotableSalary);

//                Console.ReadLine();
//            }
//            public static bool IfPromotableExperience5(Employee employee)
//            {
//                if (employee.Experience >= 5)
//                    return true;
//                else
//                    return false;
//            }
//            //using another logic for promotion
//            public static bool IfPromotableExperience9(Employee employee)
//            {
//                if (employee.Experience >= 9)
//                    return true;
//                else
//                    return false;
//            }

//            //using another logic for promotion
//            public static bool IfPromotableSalary(Employee employee)
//            {
//                if (employee.Salary >= 10000)
//                    return true;
//                else
//                    return false;
//            }
//        }
//    }

//    public delegate bool DelegateIfPromotable(Employee employee);

//    public class Employee
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }

//        public int Salary { get; set; }
//        public int Experience { get; set; }

//        public static void PromoteEmployee(List<Employee> employeeList, DelegateIfPromotable IsEligibleToPromote)
//        {
//            foreach (Employee employee in employeeList)
//                if (IsEligibleToPromote(employee))
//                    Console.WriteLine(employee.Name + " Promoted");
//        }
//    }
















}
}
