using System;
using System.Collections.Generic;
using System.Linq;
namespace AbdelilahAchir2
{
    class Program
    {
        static void Main()
        {
            CalculateSalary();
        }
        public static void CalculateSalary() 
        {

            double BudgetTotal = 0;
            double BudgetHours = 0;
            Employee listemployes = new Employee
            {
                name = "mathemathics"
            };
            listemployes.AddWorkers("paco", "gimenez", 200.0, 10);
            listemployes.AddWorkers("angel", "fernandez", 200.0, 5);
            listemployes.AddWorkers("maria", "fernandez", 200.0, 20);
            listemployes.AddWorkers("hanna", "fernandez", 200.0, 5);
            listemployes.AddWorkers("Elisabeth","Persson",200.0,50);
           // SalaryCalculator Salary = new SalaryCalculator();
           // SalaryCalculator SalaryPerEmployee = new SalaryCalculator();
            // ListEmployees currentWorker2 = listemployes.workers[0];
           /* for (int x = 0; x <= listemployes.workers.Count - 1; x++)
            {
                ListEmployees currentWorker = listemployes.workers[x];
                Salary.workers.Add(currentWorker);
                // Console.WriteLine("Name: " + currentWorker.name + "The salary total is :   " + Salary.Salary);
            }*/


            for (int i = 0; i >= listemployes.workers.Count; i++)
            {
                ListEmployees currentWorker = listemployes.workers[i];
                listemployes.workers.Add(currentWorker);
            }

            double numberOfEmployees = listemployes.workers.Count();
            double HourlyEmployed = numberOfEmployees / 3;

            //add 5 % to the salary of the 1 third hourly employed
            Console.WriteLine(" \n SALARY OF WORKERS DELTID  \n  ");
            for (int x = 0; x < listemployes.workers.Count / 3; x++)
            {
                Random random = new Random();
                double hours = random.Next(1, 169);
                ListEmployees currentWorker = listemployes.workers[x];
                currentWorker.hoursWorked = hours;
                currentWorker.salary = currentWorker.salary * hours;
                //total hours

                if (currentWorker.monthsWorked >= 5)
                {
                    double monthsWorked = currentWorker.monthsWorked / 5;
                    for (int i = 0; i < monthsWorked; i++)
                    {
                        double incrementS = currentWorker.salary * 0.05;
                        currentWorker.salary = currentWorker.salary + incrementS;
                        currentWorker.salary = Math.Round(currentWorker.salary, 2);
                    }
                }
                BudgetTotal = BudgetTotal + currentWorker.salary;
                BudgetTotal = Math.Round(BudgetTotal, 2);
                Console.WriteLine($"Name:   {currentWorker.name }.  The salary total is :     {currentWorker.salary} $.    hours Worked:       { currentWorker.hoursWorked}. \n");
            }

            //calculation of the salaries of all workers fulltime

            Console.WriteLine("  SALARY OF THE WORKERS HELTID  \n");
            for (int x = 0; x < listemployes.workers.Count - (listemployes.workers.Count / 3); x++)
            {
                double hours = 169;
                ListEmployees currentWorker = listemployes.workers[x];
                currentWorker.hoursWorked = hours;
                //Basic salary
                currentWorker.salary = currentWorker.salary * hours;
                //budget hours workers full time
                BudgetHours += currentWorker.hoursWorked;
                if (currentWorker.monthsWorked >= 5)
                {
                    double monthsWorked = currentWorker.monthsWorked / 5;
                    for (int i = 0; i < monthsWorked; i++)
                    {
                        double incrementS = currentWorker.salary * 0.05;
                        currentWorker.salary = currentWorker.salary + incrementS;
                        currentWorker.salary = Math.Round(currentWorker.salary, 2);
                    }
                }
                BudgetTotal = BudgetTotal + currentWorker.salary;
                BudgetTotal = Math.Round(BudgetTotal, 2);
                Console.WriteLine($"Name:  { currentWorker.name}.   The salary total is :  {currentWorker.salary} $. hours Worked:   {currentWorker.hoursWorked}. \n");
            }
            Console.WriteLine("\tBUDGET TOTAL WAGES : \n");
            Console.WriteLine("\t" + BudgetTotal + " $\n");


        }

        public class ListEmployees
        {

            public string name;
            public string surname;
            public double salary;
            public double monthsWorked;
            public double hoursWorked;

        }



        public class Employee
        {

            public string name;
            public List<ListEmployees> workers;
            public Employee()
            {
                workers = new List<ListEmployees>();
            }

            public void AddWorkers(string name, string surname, double salary, double monthsWorked)
            {
                ListEmployees worker = new ListEmployees
                {

                    name = name,
                    surname = surname,
                    salary = salary,
                    monthsWorked = monthsWorked,
                    hoursWorked = 0

                };
                workers.Add(worker);

            }

        }


        // i made a class salary calculator but the calculations they were not right, so i made everything in the ´Main method.
        public class SalaryCalculator
        {
            //public List<ListEmployees> workers = new List<ListEmployees>();
            public double Salary
            {
                get
                {
                    double salaryTotal = 0;
                    double incrementSalary = 0;
                    
                    ListEmployees worker = new ListEmployees();
                    if (worker.monthsWorked >= 5)
                    { 
                        double totalMonthsWorked = worker.monthsWorked / 5;
                        for (int i = 0; i <= totalMonthsWorked; i++)
                        {
                            incrementSalary = worker.salary * 0.05;
                            worker.salary += incrementSalary;
                            Console.WriteLine(worker.salary);
                        }
                    }
                    salaryTotal = worker.salary;
                    return salaryTotal;
                }

            }

        }
    }

}














