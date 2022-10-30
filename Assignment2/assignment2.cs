using System;


namespace Program
{
    class Employee
    {


        private int EmpNo;
        private string EmpName;
        private int Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;



        public static void Main(string[] arga)
        {
            Employee emp = new Employee();
             emp.Salary = 5000;
            double sal = emp.Salary;
            


            if (sal < 5000)
            {
                emp.HRA = emp.Salary * .10;
                emp.TA = emp.Salary * .05;
                emp.DA = emp.Salary * .15;
                double S = emp.Salary;
                double H = emp.HRA;
                double T = emp.TA;
                double D = emp.DA;
                emp.GrossSalary = S + H + T + D;
                double GS = emp.GrossSalary;
                emp.PF = (GS / 100) * 10;
                emp.TDS = (GS / 100) * 18;
                emp.NetSalary = GS - (emp.PF + emp.TDS);

            }
            else if (sal < 10000)
            {
                emp.HRA = emp.Salary * .15;
                emp.TA = emp.Salary * .10;
                emp.DA = emp.Salary * .20;
                double S = emp.Salary;
                double H = emp.HRA;
                double T = emp.TA;
                double D = emp.DA;
                emp.GrossSalary = S + H + T + D;
                double GS = emp.GrossSalary;
                emp.PF = (GS / 100) * 10;
                emp.TDS = (GS / 100) * 18;
                emp.NetSalary = GS - (emp.PF + emp.TDS);
            }
            else if (sal < 15000)
            {
                emp.HRA = emp.Salary * .20;
                emp.TA = emp.Salary * .15;
                emp.DA = emp.Salary * .25;
                double S = emp.Salary;
                double H = emp.HRA;
                double T = emp.TA;
                double D = emp.DA;
                emp.GrossSalary = S + H + T + D;
                double GS = emp.GrossSalary;
                emp.PF = (GS / 100) * 10;
                emp.TDS = (GS / 100) * 18;
                emp.NetSalary = GS - (emp.PF + emp.TDS);
            }
            else if (sal < 20000)
            {
                emp.HRA = emp.Salary * .25;
                emp.TA = emp.Salary * .20;
                emp.DA = emp.Salary * .30;
                double S = emp.Salary;
                double H = emp.HRA;
                double T = emp.TA;
                double D = emp.DA;
                emp.GrossSalary = S + H + T + D;
                double GS = emp.GrossSalary;
                emp.PF = (GS / 100) * 10;
                emp.TDS = (GS / 100) * 18;
                emp.NetSalary = GS - (emp.PF + emp.TDS);
            }
            else if (sal >= 20000)
            {
                emp.HRA = emp.Salary * .30;
                emp.TA = emp.Salary * .25;
                emp.DA = emp.Salary * .35;
                double S = emp.Salary;
                double H = emp.HRA;
                double T = emp.TA;
                double D = emp.DA;
                emp.GrossSalary = S + H + T + D;
                double GS = emp.GrossSalary;
                emp.PF = (GS / 100) * 10;
                emp.TDS = (GS / 100) * 18;
                emp.NetSalary = GS - (emp.PF + emp.TDS);
            }
            //Console.WriteLine( " Employee Number  =  " + emp.EmpNo + " \n Employee Name = " +  emp.EmpName + " \n Employee Salary = "+emp.Salary);
            Console.WriteLine(" Gross Salary = " + emp.GrossSalary + " \n PF = " + emp.PF + "\n Net Salary " + emp.NetSalary);

        }
    }
}